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
    public partial class Form3 : Form
    {
        private Personelislemleri personelIslemleri;
        public Action<object, object> VeriAlindi { get; internal set; }


        public Form3()
        {
            InitializeComponent();
        }


        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            //yeniCalisan1.Isim = textBox1.Text; 
        }

        public Form3(Personelislemleri personelIslemleri)
        {
            InitializeComponent();
            this.personelIslemleri = personelIslemleri;
        }

        public string isim;
        public string soyisim;

        private void Form3_Load(object sender, EventArgs e)
        {
            textBox1.Text = personelIslemleri.IzinGoruntule();
            textBox2.Text = personelIslemleri.MaasGoruntule();


            // Form2'den alinan isim ve soyisim değerlerini goster
            textBox1.Text = isim;
            textBox2.Text = soyisim;

        }

        //form3 oneri-sikayet kaydini txt dosyasina yapan kod blogu
        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mesajınız Gönderilmiştir!\nVaktinizi Ayırdığınız İçin Teşekkürler.");
            textBox3.Clear();
            
            string text = textBox3.Text;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Metin Dosyaları|*.txt";
            saveFileDialog.Title = "Not Defteri Kaydet";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = saveFileDialog.FileName;
                File.WriteAllText(fileName, text);
                MessageBox.Show("Not Defteri dosyası başarıyla kaydedildi.");
            }
            

        }
    }
}

