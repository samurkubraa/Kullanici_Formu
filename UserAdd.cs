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
    public partial class UserAdd : Form
    {
        public UserAdd()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                           initial catalog=KullaniciFormu; integrated security=true");
        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }

                SqlCommand command = new SqlCommand("Insert Into Kullaniciekle " +
                    "(Ad,Soyad,Kullanici_Adi,Email,Sifre) values (@Ad,@Soyad,@Kullanici_Adi," +
                    "@Email,@Sifre)", connection);

               
                command.Parameters.AddWithValue("@Ad", textBox1.Text);
                command.Parameters.AddWithValue("@Soyad", textBox2.Text);
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

        private void btnupdate_Click(object sender, EventArgs e)
        {
            KullanicilarDal kullanicilardal = new KullanicilarDal();
            dgwupdate.DataSource = kullanicilardal.KullanicilariGetir();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
        }
    }
}
