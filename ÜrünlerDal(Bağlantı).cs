using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ürün_Listesi
{
    public class ÜrünlerDal_Bağlantı_
    {
        SqlConnection connection = new SqlConnection(@"server=(localdb)\mssqllocaldb; initial catalog=Ürünler; integrated security= true; "); // Veri tabanına bağlantı satırı.
        public List<Ürünler> Yazdir()
        {
          
            if (connection.State == ConnectionState.Closed) ;  // eğer bağlantı durmum kapalıysa aşağıdakilleri yap. Yani bağlantıyı aç.
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select * From Ürünler", connection); // connection ile Ürünler tablosuna bağlandık. Veri tabanına bağlanan yol.
            SqlDataReader reader = command.ExecuteReader(); // tablodaki verileri okuduk.

            // OKUDUKTAN SONRA VERİ TABANINDAKİ ÜRÜNLERİ BİZİM OLUŞTURDUĞUMU ÜRÜNLERE  SIRALAMAMIZ GEREKİR.
            List<Ürünler> ürünler = new List<Ürünler>();
            while (reader.Read())  // Yukarıda okuduklarını oku.
            {
                Ürünler ürün = new Ürünler
                {
                    Id = Convert.ToInt32(reader["Id"]),
                    İsim = reader["İsim"].ToString(),
                    Stok = Convert.ToInt32(reader["Stok"]),
                    Fiyat = Convert.ToInt32(reader["Fiyat"]),

                };
                ürünler.Add(ürün);  // While dngüsünün içindeki tek tek tanımlanan ürünleri yukrıda sıralamak için oluşturduğumuz ürünler değişkenine ekledik.
            }
            reader.Close();
            connection.Close();
            return ürünler;
        }

        public void ekle(Ürünler ürün) // Ürünler tablosundaki ürünlere ekle
        {
            if (connection.State == ConnectionState.Closed) ;  // eğer bağlantı durmum kapalıysa aşağıdakilleri yap. Yani bağlantıyı aç.
            {
                connection.Open();   // Bu kodu buraya yazma sebebimiz ekle methodunun sürekli ürün eklememesi. Server bağlantısı kapalıysa önce aç sonra ekle.
            }
            SqlCommand command = new SqlCommand("insert into Ürünler values(@İsim,@Fiyat,@Stok)", connection); // Ürünler tablosuna değer ekle.
            command.Parameters.AddWithValue("İsim",ürün.İsim); // Ürünün içindeki isme göre isim ekleyeceğim.
            command.Parameters.AddWithValue("Fiyat",ürün.Fiyat); 
            command.Parameters.AddWithValue("Stok",ürün.Stok);
            command.ExecuteNonQuery(); // Yazdığımız kodun çalışıp çalışmadığını kontrol eder.

            connection.Close();
        }
        public void Güncelle(Ürünler ürün)
        {
            if (connection.State == ConnectionState.Closed)
                connection.Open();
            SqlCommand command = new SqlCommand("Update Ürünler set İsim= @İsim, Fiyat=@Fiyat, Stok=@Stok Where Id=@Id",connection);
            command.Parameters.AddWithValue("İsim", ürün.İsim);
            command.Parameters.AddWithValue("Fiyat", ürün.Fiyat);
            command.Parameters.AddWithValue("Stok", ürün.Stok);
            command.Parameters.AddWithValue("Id", ürün.Id);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void Sil(Ürünler ürün)
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Delete from Ürünler Where Id=@Id", connection);
            command.Parameters.AddWithValue("Id", ürün.Id);
            command.ExecuteNonQuery();
            connection.Close();

        }
    }
}
