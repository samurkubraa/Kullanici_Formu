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
    public partial class UserUpdate : Form
    {
        public UserUpdate()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                           initial catalog=KullaniciFormu; integrated security=true");
        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("Update Kullaniciekle set Ad=@Ad,Soyad=@Soyad," +
                    "Kullanici_Adi=@Kullanici_Adi,Email=@Email,Sifre=@Sifre Where Ad=@Ad", connection);


                command.Parameters.AddWithValue("@Ad", adupdate.Text);
                command.Parameters.AddWithValue("@Soyad", soyadupdate.Text);
                command.Parameters.AddWithValue("@Kullanici_Adi", textBox3.Text);
                command.Parameters.AddWithValue("@Email", textBox4.Text);
                command.Parameters.AddWithValue("@Sifre", textBox5.Text);

                command.ExecuteNonQuery();

                connection.Close();
                MessageBox.Show("Kaydedildi.");

            }

            catch (Exception hata)
            {
                MessageBox.Show("Hata : " + hata);
            }
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            KullanicilarDal kullanicilardal = new KullanicilarDal();
            dgwupdate.DataSource = kullanicilardal.KullanicilariGetir();
        }
    }
}
