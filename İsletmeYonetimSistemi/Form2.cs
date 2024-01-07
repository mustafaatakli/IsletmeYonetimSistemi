using Proje.Sinif;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace İsletmeYonetimSistemi
{
    public partial class Form2 : Form
    {
        private Personelislemleri Personelislemleri;

        private object listBox1Calisanlar;

        private List<TemelCalisan> calisan1;



        public Form2()
        {
            InitializeComponent();
            Personelislemleri = new Personelislemleri();
        }



        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {
        }


        Yoneticiislemleri yeniCalisan1;

        //form2 personel kaydı yapan blok 
        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0; int y = 0; int z = 0; int t = 0; int s = 0;
            yeniCalisan1 = new Yoneticiislemleri();
            yeniCalisan1.Isim = textBox1.Text;
            yeniCalisan1.Soyisim = textBox2.Text;
            yeniCalisan1.Maas = int.Parse(textBox8.Text);
            yeniCalisan1.IzinGunu = int.Parse(textBox9.Text);
            yeniCalisan1.Departman = textBox3.Text;
            yeniCalisan1.KullaniciAdi = textBox7.Text;
            Yoneticiislemleri.Yon_list.Add(yeniCalisan1);

            //kaydet butonu ile aldıgım personel bilgilerinin listeye yazdırılması
            listBox1.Items.Clear();
            for (x = 0; x < Yoneticiislemleri.Yon_list.Count; x++)
            {
                listBox1.Items.Add(Yoneticiislemleri.Yon_list[x].Isim + " | " + Yoneticiislemleri.Yon_list[x].Soyisim + " | " + Yoneticiislemleri.Yon_list[x].Maas + " | " + Yoneticiislemleri.Yon_list[x].IzinGunu +
                " | " + Yoneticiislemleri.Yon_list[x].Departman + " | " + Yoneticiislemleri.Yon_list[x].KullaniciAdi);
            }

            //departman bilgisini degistiren kod blogu
            comboBox1.Items.Clear();
            for (y = 0; y < Yoneticiislemleri.Yon_list.Count; y++)
            {
                comboBox1.Items.Add(Yoneticiislemleri.Yon_list[y].Departman);


            }

            //maas bilgisini degistiren kod blogu
            comboBox2.Items.Clear();
            for (t = 0; t < Yoneticiislemleri.Yon_list.Count; t++)
            {
                comboBox2.Items.Add(Yoneticiislemleri.Yon_list[t].Maas);


            }

            //izingunu bilgisini degistiren kod blogu
            comboBox4.Items.Clear();
            for (s = 0; s < Yoneticiislemleri.Yon_list.Count; s++)
            {
                comboBox4.Items.Add(Yoneticiislemleri.Yon_list[s].IzinGunu);


            }

            //kaydet butonu ile aldıgım personel bilgilerinin secilebilir listeye yazdırılması
            comboBox3.Items.Clear();
            for (z = 0; z < Yoneticiislemleri.Yon_list.Count; z++)
            {
                comboBox3.Items.Add(Yoneticiislemleri.Yon_list[z].Isim + " | " + Yoneticiislemleri.Yon_list[z].Soyisim + " | " + Yoneticiislemleri.Yon_list[z].Maas + " | " + Yoneticiislemleri.Yon_list[z].IzinGunu +
                " | " + Yoneticiislemleri.Yon_list[z].Departman + " | " + Yoneticiislemleri.Yon_list[z].KullaniciAdi);
            }


            //p_islemleri adinda yeni bir nesnenin olusturulması
            Proje.Sinif.Personelislemleri p_islemleri = new Proje.Sinif.Personelislemleri();

            //Ibilgiler den kalitim alip bilgiler sinifinin olusturulmasi
            Proje.Sinif.IBilgiler bilgiler = (Proje.Sinif.IBilgiler)p_islemleri;

            string izinBilgisi = textBox9.Text;
            string maasBilgisi = textBox8.Text;

            Personelislemleri.IzinGoruntule(izinBilgisi);
            Personelislemleri.MaasGoruntule(maasBilgisi);

            Form3 form3 = new Form3(Personelislemleri);
        }


        //personel departmanı degisteren kod blogu
        private void button4_Click(object sender, EventArgs e)
        {
            int x = 0; int y = 0; int m = 0;
            listBox1.Items.Clear();

            Yoneticiislemleri.Yon_list[comboBox1.SelectedIndex].Departman = textBox5.Text;

            for (m = 0; m < Yoneticiislemleri.Yon_list.Count; m++)
            {
                listBox1.Items.Add(Yoneticiislemleri.Yon_list[m].Isim + " | " + Yoneticiislemleri.Yon_list[m].Soyisim + " | " + Yoneticiislemleri.Yon_list[m].Maas + " | " + Yoneticiislemleri.Yon_list[m].IzinGunu +
                " | " + Yoneticiislemleri.Yon_list[m].Departman + " | " + Yoneticiislemleri.Yon_list[m].KullaniciAdi);

            }
        }



        //personel kaydı silen kod blogu
        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(comboBox3.SelectedItem);
            comboBox1.Items.Remove(comboBox3.SelectedItem);
            comboBox2.Items.Remove(comboBox3.SelectedItem);
            comboBox4.Items.Remove(comboBox3.SelectedItem);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        //personel maas bilgisini guncelleyen kod blogu
        private void button3_Click(object sender, EventArgs e)
        {
            int x = 0; int y = 0; int n = 0;
            listBox1.Items.Clear();

            Yoneticiislemleri.Yon_list[comboBox2.SelectedIndex].Maas = int.Parse(textBox4.Text);

            for (n = 0; n < Yoneticiislemleri.Yon_list.Count; n++)
            {
                listBox1.Items.Add(Yoneticiislemleri.Yon_list[x].Isim + " | " + Yoneticiislemleri.Yon_list[n].Soyisim + " | " + Yoneticiislemleri.Yon_list[n].Maas + " | " + Yoneticiislemleri.Yon_list[n].IzinGunu +
                " | " + Yoneticiislemleri.Yon_list[n].Departman + " | " + Yoneticiislemleri.Yon_list[n].KullaniciAdi);

            }//for
        }

        //personel izin bilgisini guncelleyen kod blogu 
        private void button6_Click(object sender, EventArgs e)
        {
            int x = 0; int y = 0; int p = 0;
            listBox1.Items.Clear();

            Yoneticiislemleri.Yon_list[comboBox4.SelectedIndex].IzinGunu = int.Parse(textBox6.Text);

            for (p = 0; p < Yoneticiislemleri.Yon_list.Count; p++)
            {
                listBox1.Items.Add(Yoneticiislemleri.Yon_list[x].Isim + " | " + Yoneticiislemleri.Yon_list[p].Soyisim + " | " + Yoneticiislemleri.Yon_list[p].Maas + " | " + Yoneticiislemleri.Yon_list[p].IzinGunu +
                " | " + Yoneticiislemleri.Yon_list[p].Departman + " | " + Yoneticiislemleri.Yon_list[p].KullaniciAdi);

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox5.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox4.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox6.Clear();
        }

        //form1 e geri donus butonu
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Form1 frmac = new Form1();
            Form3 form3 = new Form3();


            frmac.Show();
            this.Hide();
            //Form1 frm2 = new Form1();
            //frm2.ShowDialog();


        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
        }
    }
}

