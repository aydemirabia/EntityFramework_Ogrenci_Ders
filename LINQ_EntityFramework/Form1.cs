using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Entity_IlkOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        EntityFrameworkLINQ_SinavOgrenciEntities db = new EntityFrameworkLINQ_SinavOgrenciEntities();
        private void btnDersListele_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=RABIA-AYDEMIR;Initial Catalog=EntityFrameworkLINQ_SinavOgrenci;Integrated Security=True");
            SqlCommand komut = new SqlCommand("select * from tbl_dersler", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btnOgrenciListele_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.tbl_ogrenci.ToList();
            //datagridview'de fotoğrafların ve notların görünmesini engellemek için
            dataGridView1.Columns[3].Visible = false;
            dataGridView1.Columns[4].Visible = false;
        }

        private void btnNotListele_Click(object sender, EventArgs e)
        {
            var query = from item in db.tbl_notlar
                        select new
                        {
                            item.NOTID,
                            item.tbl_ogrenci.OGRAD,
                            item.tbl_ogrenci.OGRSOYAD,
                            item.tbl_dersler.DERSAD,
                            item.SINAV1,
                            item.SINAV2,
                            item.SINAV3,
                            item.ORTALAMA,
                            item.DURUM
                        };
            dataGridView1.DataSource = query.ToList();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            tbl_ogrenci t = new tbl_ogrenci();
            t.OGRAD = txtOgrAd.Text;
            t.OGRSOYAD = txtOgrSoyad.Text;
            db.tbl_ogrenci.Add(t);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Listeye Eklendi!");
        }

        private void btnDersKaydet_Click(object sender, EventArgs e)
        {
            tbl_dersler d = new tbl_dersler();
            d.DERSAD = txtDersAd.Text;
            db.tbl_dersler.Add(d);
            db.SaveChanges();
            MessageBox.Show("Ders Listeye Eklendi!");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.tbl_ogrenci.Find(id);
            db.tbl_ogrenci.Remove(x);
            db.SaveChanges();
            MessageBox.Show("Öğrenci Sistemden Silindi!");
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtOgrID.Text);
            var x = db.tbl_ogrenci.Find(id);
            x.OGRAD = txtOgrAd.Text;
            x.OGRSOYAD = txtOgrSoyad.Text;
            x.FOTOGRAF = txtOgrFoto.Text;
            db.SaveChanges();
            MessageBox.Show("Öğrenci Bilgileri Güncellendi!");
        }

        private void btnProsedur_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = db.not_listesi();
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            //lambda ifadeler için--> tbl_ogrenci bi sınıf where şartından sonrakiler de birer property denilebilir
            //lambda ifadelerde birden fazla seçim de yapılabilir
            // & işareti ile | işareti kullanılır
            dataGridView1.DataSource = db.tbl_ogrenci.Where(x => x.OGRAD == txtOgrAd.Text
            |
            x.OGRSOYAD == txtOgrSoyad.Text).ToList();
        }

        private void txtOgrAd_TextChanged(object sender, EventArgs e)
        {
            string aranan = txtOgrAd.Text;
            var degerler = from item in db.tbl_ogrenci
                           where item.OGRAD.Contains(aranan)
                           select item;
            dataGridView1.DataSource = degerler.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbIsimSiralama.Checked == true)
            {
                List<tbl_ogrenci> liste1 = db.tbl_ogrenci.OrderBy(p => p.OGRAD).ToList();
                dataGridView1.DataSource = liste1;
            }
            if (rbIsimSıralamaZ.Checked == true)
            {
                List<tbl_ogrenci> liste2 = db.tbl_ogrenci.OrderByDescending(p => p.OGRAD).ToList();
                dataGridView1.DataSource = liste2;
            }
            if (rbIlkUcSiralama.Checked == true)
            {
                List<tbl_ogrenci> liste3 = db.tbl_ogrenci.OrderBy(p=>p.OGRAD).Take(3).ToList();
                dataGridView1.DataSource = liste3;
            }
            if (rbIDSiralama.Checked == true)
            {
                List<tbl_ogrenci> liste4 = db.tbl_ogrenci.Where(p => p.ID == 5).ToList();
                dataGridView1.DataSource = liste4;
            }
            if (rbA_ile_baslayanlar.Checked == true)
            {
                List<tbl_ogrenci> liste5 = db.tbl_ogrenci.Where(p => p.OGRAD.StartsWith("a")).ToList();
                dataGridView1.DataSource = liste5;
            }
            if (rbA_ile_bitenler.Checked == true)
            {
                List<tbl_ogrenci> liste6 = db.tbl_ogrenci.Where(p => p.OGRAD.EndsWith("a")).ToList();
                dataGridView1.DataSource = liste6;
            }
            if (rbToplamOgrenciSayisi.Checked == true)
            {
                int toplam = db.tbl_ogrenci.Count();
                MessageBox.Show(toplam.ToString(), "Toplam Öğrenci Sayısı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (rbSinav1.Checked == true)
            {
                var toplam = db.tbl_notlar.Sum(p => p.SINAV1);
                MessageBox.Show("Sınav1 Toplamı: " + toplam.ToString());
            }
            if (rbSinav1Ort.Checked == true)
            {
                var ortalama = db.tbl_notlar.Average(p => p.SINAV1);
                MessageBox.Show("Sınav1 Ortalaması: " + ortalama.ToString());
            }
            if (rbSinav2Toplami.Checked == true)
            {
                var toplam = db.tbl_notlar.Sum(p => p.SINAV2);
                MessageBox.Show("Sınav2 Toplamı: " + toplam.ToString());
            }
            if (rbSinav2Ortalamasi.Checked == true)
            {
                var ortalama = db.tbl_notlar.Average(p => p.SINAV2);
                MessageBox.Show("Sınav2 Ortalaması: " + ortalama.ToString());
            }
            if (rbSinav3Toplami.Checked == true)
            {
                var toplam = db.tbl_notlar.Sum(p => p.SINAV3);
                MessageBox.Show("Sınav3 Toplamı: " + toplam.ToString());
            }
            if (rbSinav3Ortalamasi.Checked == true)
            {
                var ortalama = db.tbl_notlar.Average(p => p.SINAV3);
                MessageBox.Show("Sınav3 Ortalaması: " + ortalama.ToString());
            }
        }

        private void btnJoinGetirme_Click(object sender, EventArgs e)
        {
            var sorgu = from vt1 in db.tbl_notlar
                        join vt2 in db.tbl_ogrenci
                        on vt1.OGR equals vt2.ID
                        join vt3 in db.tbl_dersler
                        on vt1.DERS equals vt3.DERSID
                        select new
                        {
                            OGRENCI = vt2.OGRAD + " " + vt2.OGRSOYAD,
                            DERS = vt3.DERSAD,
                            SINAV1 = vt1.SINAV1,
                            SINAV2 = vt1.SINAV2,
                            SINAV3 = vt1.SINAV3,
                            ORTALAMA=vt1.ORTALAMA
                        };
            dataGridView1.DataSource = sorgu.ToList();
        }
    }
}
