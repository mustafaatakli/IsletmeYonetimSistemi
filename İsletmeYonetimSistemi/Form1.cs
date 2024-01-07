using Proje.Sinif;
using System;
using System.Windows.Forms;
using static İsletmeYonetimSistemi.Form1;
using static System.Windows.Forms.DataFormats;

namespace İsletmeYonetimSistemi
{
    public partial class Form1 : Form
    {
        private List<TemelCalisan> calisanlar;

        public Form1()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }


        private void label5_Click(object sender, EventArgs e)
        {
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            {
                Close();
                // Form3'ü aç
                Form3 form3 = new Form3();
                form3.Show();
            };
        }
 
        //yeni listenin olusturulmasi
        public List<Yoneticiislemleri> List = new List<Yoneticiislemleri>();


        //form1 personel giris butonu
        public void button4_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            Form3 f3 = new Form3();
            // Form2 f2 = new Form2();
            // f3.textBox4.Text = textBox4.Text;
            f3.textBox5.Text = textBox3.Text;                        //form1 de personel girisi icin soyad bilgisini al

            var Liste = Yoneticiislemleri.Yon_list.FirstOrDefault(p => p.KullaniciAdi == textBox4.Text);     //yeni liste olustur
            List.Add(Liste);                                         //alinan degerleri listeye ekle
            f3.textBox7.Text = List[0].Departman;                    //form3 de gosterilecek departman bilgisi al
            f3.textBox1.Text = List[0].IzinGunu.ToString();          //form3 de gosterilecek izingunu bilgisi al
            f3.textBox2.Text = List[0].Maas.ToString();              //form3 de gosterilecek maas bilgisi al
            f3.textBox4.Text = List[0].Isim;                         //form3 de gosterilecek isim bilgisini al

            //admin kisisinin kaydettigi personellerin giris sorgusunu yapan kod blogu
            if (Yoneticiislemleri.Yon_list.Any(p => p.KullaniciAdi == textBox4.Text && p.Soyisim == textBox3.Text))
            {
                MessageBox.Show("Giriş başarılıdır!\nHoş geldiniz.");
                //Form3 frm3 = new Form3();
                f3.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!\nLütfen Tekrar Deneyiniz.");
            }
        }


        //form1 admin giris sorgusu
        private void button1_Click(object sender, EventArgs e)
        {
            //default ayarlar
            string kullaniciAdi = "admin";
            string sifre = "12345";

            string girilenKullaniciAdi = textBox1.Text;
            string girilenSifre = textBox2.Text;

            if (girilenKullaniciAdi == kullaniciAdi && girilenSifre == sifre)
            {
                MessageBox.Show("Giriş başarılıdır!\nHoş Geldiniz.");
                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı!\nLütfen Tekrar Deneyiniz.");
            }


        }


        private void button5_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
            textBox3.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label6.Text = label6.Text.Substring(1) + label6.Text.Substring(0, 1);
        }
    }
}