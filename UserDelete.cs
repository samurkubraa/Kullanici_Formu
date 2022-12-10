using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciFormu
{
    public partial class UserDelete : Form
    {
        public UserDelete()
        {
            InitializeComponent();
        }

        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                           initial catalog=KullaniciFormu; integrated security=true");
        private void btnsil_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
            kullanicilar.Ad = deletead.Text;
            

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
               

                SqlCommand command = new SqlCommand("Delete from Kullaniciekle" +
                    " Where Ad=@Ad", connection);
               
                command.Parameters.AddWithValue("@Ad",kullanicilar.Ad);   
                
                command.ExecuteNonQuery();
                
                connection.Close();
                MessageBox.Show("Kayıt Silindi");
            }

            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata);
            }   
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            KullanicilarDal kullanicilardal = new KullanicilarDal();
            dgwupdate.DataSource = kullanicilardal.KullanicilariGetir();
        }
    }
}
