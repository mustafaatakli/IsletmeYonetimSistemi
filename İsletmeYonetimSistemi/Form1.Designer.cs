namespace İsletmeYonetimSistemi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            groupBox1 = new GroupBox();
            button1 = new Button();
            button2 = new Button();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            groupBox2 = new GroupBox();
            checkBox1 = new CheckBox();
            button3 = new Button();
            button4 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label5 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(61, 81);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(294, 273);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yönetici Girişi";
            // 
            // button1
            // 
            button1.BackColor = Color.Tomato;
            button1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(155, 171);
            button1.Name = "button1";
            button1.Size = new Size(113, 48);
            button1.TabIndex = 7;
            button1.Text = "GİRİŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Yellow;
            button2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(21, 171);
            button2.Name = "button2";
            button2.Size = new Size(113, 48);
            button2.TabIndex = 5;
            button2.Text = "TEMİZLE";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox2.Location = new Point(150, 91);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Şifre Giriniz";
            textBox2.Size = new Size(118, 23);
            textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox1.Location = new Point(150, 33);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "K. Adınızı Giriniz";
            textBox1.Size = new Size(118, 23);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(21, 92);
            label2.Name = "label2";
            label2.Size = new Size(41, 17);
            label2.TabIndex = 1;
            label2.Text = "Şifre :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(21, 36);
            label1.Name = "label1";
            label1.Size = new Size(85, 17);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı :";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(checkBox1);
            groupBox2.Controls.Add(button3);
            groupBox2.Controls.Add(button4);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Underline, GraphicsUnit.Point);
            groupBox2.ForeColor = Color.White;
            groupBox2.Location = new Point(465, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(295, 273);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Personel Girişi";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point);
            checkBox1.ForeColor = Color.White;
            checkBox1.Location = new Point(21, 132);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(233, 21);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Kullanım Koşullarını Kabul Ediyorum.";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button3
            // 
            button3.BackColor = Color.Yellow;
            button3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(21, 171);
            button3.Name = "button3";
            button3.Size = new Size(113, 48);
            button3.TabIndex = 5;
            button3.Text = "TEMİZLE";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSeaGreen;
            button4.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(155, 171);
            button4.Name = "button4";
            button4.Size = new Size(113, 48);
            button4.TabIndex = 4;
            button4.Text = "GİRİŞ";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox3.Location = new Point(150, 88);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Soyadınızı Giriniz";
            textBox3.Size = new Size(118, 23);
            textBox3.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point);
            textBox4.Location = new Point(150, 30);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "K. Adınızı Giriniz";
            textBox4.Size = new Size(118, 23);
            textBox4.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(21, 89);
            label3.Name = "label3";
            label3.Size = new Size(51, 17);
            label3.TabIndex = 1;
            label3.Text = "Soyad :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(21, 33);
            label4.Name = "label4";
            label4.Size = new Size(85, 17);
            label4.TabIndex = 0;
            label4.Text = "Kullanıcı Adı :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label6.Location = new Point(51, 23);
            label6.Name = "label6";
            label6.Size = new Size(396, 30);
            label6.TabIndex = 8;
            label6.Text = "İŞLETME PERSONEL YÖNETİM SİSTEMİ®";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Tahoma", 9F, FontStyle.Italic, GraphicsUnit.Point);
            label5.Location = new Point(783, 445);
            label5.Name = "label5";
            label5.Size = new Size(31, 14);
            label5.TabIndex = 9;
            label5.Text = "v1.0";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGray;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(820, 468);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "IsletmePersonelYonetimSistemi";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button button2;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private CheckBox checkBox1;
        private Button button3;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label5;
        private Button button1;
        private Button button4;
        private System.Windows.Forms.Timer timer1;
    }
}