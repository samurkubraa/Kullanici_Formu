using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullaniciFormu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnkullanici_Click(object sender, EventArgs e)
        {
            UserAdd useradd=new UserAdd();
            useradd.Show();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            UserUpdate userupdate=new UserUpdate();
            userupdate.Show();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Kullanicilar kullanicilar = new Kullanicilar();
         
            UserDelete usersupdate=new UserDelete ();
            usersupdate.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
