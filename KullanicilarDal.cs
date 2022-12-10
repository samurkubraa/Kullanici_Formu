using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullaniciFormu
{
    public class KullanicilarDal
    { 
        public List<Kullanicilar> KullanicilariGetir()
        {
            SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb;
                           initial catalog=KullaniciFormu; integrated security=true");
            
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * from Kullaniciekle",connection);
            SqlDataReader reader= command.ExecuteReader();
            List<Kullanicilar> kullanicilar = new List<Kullanicilar>();
            while (reader.Read())
            {
                Kullanicilar kullanici = new Kullanicilar
                {
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    Kullanici_Adi = reader["Kullanici_Adi"].ToString(),
                    Email = reader["Email"].ToString(),
                    Sifre = Convert.ToInt32(reader["Sifre"])
                };
                kullanicilar.Add(kullanici);
            }
            reader.Close();
            connection.Close();
            return kullanicilar;
        }
        
        
    }
}
