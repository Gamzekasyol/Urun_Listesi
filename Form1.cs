using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ürün_Listesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ÜrünlerDal_Bağlantı_ ürünler = new ÜrünlerDal_Bağlantı_();

        private void Form1_Load(object sender, EventArgs e)
        {
            data_alanı.DataSource = ürünler.Yazdir();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            ürünler.ekle(new Ürünler
            {
                İsim = txtÜrün.Text,
                Fiyat = Convert.ToInt32(txtFiyat.Text),
                Stok = Convert.ToInt32(txtStok.Text),

            }) ;
            data_alanı.DataSource = ürünler.Yazdir(); // Uygulama her çalıştığında eklediğimiz ürünleri anında tabloda gösterir.
            MessageBox.Show("Ürün Eklendi!");
 
        }

        private void data_alanı_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtürüngüncelle.Text = data_alanı.CurrentRow.Cells[1].Value.ToString(); // data alnındaki satırların 1 numaralı hücresini stringe çevirip txtürüngüncelle txtboxının text alanında göster. 
            txtstokgüncelle.Text = data_alanı.CurrentRow.Cells[2].Value.ToString();
            txtfiyatgüncelle.Text = data_alanı.CurrentRow.Cells[3].Value.ToString();
        }

        private void btngüncelle_Click(object sender, EventArgs e)
        {
            Ürünler ürün = new Ürünler()
            {
                Id = Convert.ToInt32(data_alanı.CurrentRow.Cells[0].Value),
                İsim = txtürüngüncelle.Text,
                Stok = Convert.ToInt32(txtstokgüncelle.Text),
                Fiyat = Convert.ToInt32(txtfiyatgüncelle.Text)
            };
            ürünler.Güncelle(ürün); // yukarında girilen ürün değerleri ile güncelleme sağlar.
            MessageBox.Show("Ürün Güncellendi!");
            data_alanı.DataSource = ürünler.Yazdir();
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            Ürünler ürün = new Ürünler
            {
                Id = Convert.ToInt32(data_alanı.CurrentRow.Cells[0].Value),
            };
            ürünler.Sil(ürün);
            MessageBox.Show("Ürün Silindi!");
            data_alanı.DataSource = ürünler.Yazdir();
        }
    }
}
