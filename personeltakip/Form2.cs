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
//System.Text.RegularExpression (Regex) kütüphanesinin tanımlanması
using System.Text.RegularExpressions;
//Giriş-çıkış işlemlerine ilişkin kütüphanenin tanımlanması
using System.IO;

namespace personeltakip
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        //Veri tabanı dosya yole ve provider nesnesinin belirlenmesi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U9N4DTG\\SQLEXPRESS;Initial Catalog=PlateRecognition;Integrated Security=True");

        private void kullanicilari_goster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter kullanicilari_listele = new SqlDataAdapter("select tcno AS[TC KİMLİK NO],ad AS[ADI],soyad AS[SOYADI],yetki AS[YETKİ],kullaniciadi AS[KULLANICI ADI],parola AS[PAROLA] from kullanicilar1 Order By ad ASC", baglanti);
                DataSet dshafiza = new DataSet();
                kullanicilari_listele.Fill(dshafiza);
                dataGridView1.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
        private void personelleri_göster()
        {
            try
            {
                baglanti.Open();
                SqlDataAdapter personelleri_listele = new SqlDataAdapter("select tcno AS[TC KİMLİK NO],ad AS[ADI],soyad AS[SOYADI],cinsiyet[CİNSİYET],gorevi AS[GÖREVİ],gorevyeri AS[GÖREV YERİ] from personeller Order By ad ASC", baglanti);
                DataSet dshafiza = new DataSet();
                personelleri_listele.Fill(dshafiza);
                dataGridView2.DataSource = dshafiza.Tables[0];
                baglanti.Close();
            }
            catch (Exception hatamsj)
            {
                MessageBox.Show(hatamsj.Message, "Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //FORM2 AYARLARI

            pictureBox1.Height = 150;
            pictureBox1.Width = 150;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            try
            {
                pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\" + Form1.tcno + ".jpg");
            }
            catch
            {
                //pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\kullaniciresimler\\resimyok.jpg");
            }
            //Kullanıcı işlemleri sekmesi
            this.Text = "YÖNETİCİ İŞLEMLERİ";
            label12.ForeColor = Color.DarkRed;
            label12.Text = Form1.adi + " " + Form1.soyadi;
            textBox1.MaxLength = 11;
            textBox4.MaxLength = 8;
            toolTip1.SetToolTip(this.textBox1, "TC Kimlik No 11 Karakter Olmalı!");
            radioButton1.Checked = true;
            textBox2.CharacterCasing = CharacterCasing.Upper;
            textBox3.CharacterCasing = CharacterCasing.Upper;
            textBox5.MaxLength = 10;
            textBox6.MaxLength = 10;
            kullanicilari_goster();
            //Personel işlemleri sekmesi
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.Width = 100; pictureBox2.Height = 100;
            pictureBox2.BorderStyle = BorderStyle.Fixed3D;
            maskedTextBox1.Mask = "00000000000";
            maskedTextBox2.Mask = "LL????????????????????";
            maskedTextBox3.Mask = "LL????????????????????";

            maskedTextBox2.Text.ToUpper();
            maskedTextBox3.Text.ToUpper();
            comboBox1.Items.Add("Güvenlik Şefi"); comboBox1.Items.Add("Bilgi İşlem");
            comboBox1.Items.Add("Güvenlik Görevlisi");
            comboBox2.Items.Add("Kampüs İçi"); comboBox2.Items.Add("Giriş1");
            comboBox2.Items.Add("Giriş2"); comboBox2.Items.Add("Giriş3");
            comboBox2.Items.Add("Giriş4"); comboBox2.Items.Add("Giriş5");


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog resimsec = new OpenFileDialog();
            resimsec.Title = "Personel resmi seçiniz.";
            resimsec.Filter = "JPG Dosyalar(*.jpg)| *.jpg";
            if (resimsec.ShowDialog() == DialogResult.OK)
            {
                this.pictureBox2.Image = new Bitmap(resimsec.OpenFile());
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length < 11)
                errorProvider1.SetError(textBox1, "TC Kimlik No 11 karakter olmalı!");
            else
                errorProvider1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar >= 48 && (int)e.KeyChar <= 57 || (int)e.KeyChar == 8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsSeparator(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length != 8)
                errorProvider1.SetError(textBox4, "Kullanıcı adı 8 karakter olmalı!");
            else
                errorProvider1.Clear();
        }
        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == true || char.IsControl(e.KeyChar) == true || char.IsDigit(e.KeyChar) == true)
                e.Handled = false;
            else
                e.Handled = true;
        }
       
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
           
            string sifre = textBox5.Text;
            //Regex kütüphanesi İngilizce karekterleri baz aldığından, Türkçe karakterlerde sorun yaşamamak için sifre string ifadesindeki Türkçe karakterleri İngilizce karakterlere dönüştürmemiz gerekiyor.
            string duzeltilmis_sifre = "";
            duzeltilmis_sifre = sifre;
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('İ', 'I');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ı', 'i');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ç', 'C');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ç', 'c');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ş', 'S');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ş', 's');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ğ', 'G');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ğ', 'g');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ü', 'U');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ü', 'u');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('Ö', 'O');
            duzeltilmis_sifre = duzeltilmis_sifre.Replace('ö', 'o');
            if (sifre != duzeltilmis_sifre)
            {
                sifre = duzeltilmis_sifre;
                textBox5.Text = sifre;
                MessageBox.Show("Paroladaki Türkçe karakterler İngilizce karakterlere dönüştürülmüştür");

            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e) {
        }

        private void topPage1_temizle()
        {
            textBox1.Clear(); textBox2.Clear(); textBox3.Clear(); textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
        }
        private void topPage2_temizle()
        {
            pictureBox2.Image = null; maskedTextBox1.Clear(); maskedTextBox2.Clear(); maskedTextBox3.Clear();
            comboBox1.SelectedIndex = -1; comboBox2.SelectedIndex = -1;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            string yetki = "";
            bool kayitkontrol = false;
            baglanti.Open();
            SqlCommand selectsorgu = new SqlCommand("select * from kullanicilar1 where tcno='" + textBox1.Text + "'", baglanti);
            SqlDataReader kayitokuma = selectsorgu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitkontrol = true;
                break;
            }
            baglanti.Close();

            if (kayitkontrol == false)
            {
                //TC Kimlik No Kontrolü
                if (textBox1.Text.Length < 11 || textBox1.Text == "")
                    label1.ForeColor = Color.Red;
                else
                    label1.ForeColor = Color.Black;
                //Adı veri kontrolü
                if (textBox2.Text.Length < 2 || textBox2.Text == "")
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;
                //Soyadı veri kontrolü
                if (textBox3.Text.Length < 2 || textBox3.Text == "")
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Black;
                //Kullanıcı Adı veri kontrolü
                if (textBox4.Text.Length != 8 || textBox4.Text == "")
                    label5.ForeColor = Color.Red;
                else
                    label5.ForeColor = Color.Black;

               

                

                //Parola tekrar veri kontrolü

                if (textBox6.Text == "" || textBox5.Text != textBox6.Text)
                    label7.ForeColor = Color.Red;
                else
                    label7.ForeColor = Color.Black;

                if (textBox1.Text.Length == 11 && textBox1.Text != "" && textBox2.Text != "" && textBox2.Text.Length > 1 && textBox3.Text != ""
                    && textBox3.Text.Length > 1 && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != ""
                    && textBox5.Text == textBox6.Text  )
                {
                    if (radioButton1.Checked == true)
                        yetki = "Yönetici";
                    else if (radioButton2.Checked == true)
                        yetki = "Kullanıcı";
                    try
                    {
                        baglanti.Open();
                        SqlCommand eklekomutu = new SqlCommand("insert into kullanicilar1 values('" + textBox1.Text + "','" +
                            textBox2.Text + "','" + textBox3.Text + "','" + yetki + "','" + textBox4.Text + "','" + textBox5.Text + "')", baglanti);
                        eklekomutu.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Yeni kullanıcı kaydı oluşturuldu!", "SKY Personel Takip Programı",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        topPage1_temizle();
                    }
                    catch (Exception hatamsj)
                    {
                        MessageBox.Show(hatamsj.Message);
                        baglanti.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Yazı rengi kırmızı olan alanları yeniden gözden geçiriniz!", "SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else 
            {
                MessageBox.Show("Girilen TC kimlik numarası daha önceden kayıtlıdır!", "SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool kayit_arama_durumu = false;
            if (textBox1.Text.Length == 11)
            {
                baglanti.Open();

                SqlCommand selectsorgu = new SqlCommand("select * from kullanicilar1 where tcno='" + textBox1.Text +
                    "'", baglanti);
                SqlDataReader kayitokuma = selectsorgu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayit_arama_durumu = true;
                    textBox2.Text = kayitokuma.GetValue(1).ToString();
                    textBox3.Text = kayitokuma.GetValue(2).ToString();
                    if (kayitokuma.GetValue(3).ToString() == "Yönetici")
                        radioButton1.Checked = true;
                    else
                        radioButton2.Checked = true;
                    textBox4.Text = kayitokuma.GetValue(4).ToString();
                    textBox5.Text = kayitokuma.GetValue(5).ToString();
                    textBox6.Text = kayitokuma.GetValue(5).ToString();
                    break;


                }

                if (kayit_arama_durumu == false)
                {
                    MessageBox.Show("Aranan kayit bulunamadı!", "SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                baglanti.Close();

            }
            else MessageBox.Show("Lütfen 11 haneli bir TC Kimlik No giriniz!", "SKY Personel Takip Programı",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            topPage1_temizle();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            string yetki = "";
           
                //TC Kimlik No Kontrolü
                if (textBox1.Text.Length < 11 || textBox1.Text == "")
                    label1.ForeColor = Color.Red;
                else
                    label1.ForeColor = Color.Black;
                //Adı veri kontrolü
                if (textBox2.Text.Length < 2 || textBox2.Text == "")
                    label2.ForeColor = Color.Red;
                else
                    label2.ForeColor = Color.Black;
                //Soyadı veri kontrolü
                if (textBox3.Text.Length < 2 || textBox3.Text == "")
                    label3.ForeColor = Color.Red;
                else
                    label3.ForeColor = Color.Black;
                //Kullanıcı Adı veri kontrolü
                if (textBox4.Text.Length != 8 || textBox4.Text == "")
                    label5.ForeColor = Color.Red;
                else
                    label5.ForeColor = Color.Black;

                //Parola veri kontrolü
                
                //Parola tekrar veri kontrolü

                if (textBox6.Text == "" || textBox5.Text != textBox6.Text)
                    label7.ForeColor = Color.Red;
                else
                    label7.ForeColor = Color.Black;

                if (textBox1.Text.Length == 11 && textBox1.Text != "" && textBox2.Text != "" && textBox2.Text.Length > 1 && textBox3.Text != ""
                    && textBox3.Text.Length > 1 && textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != ""
                    && textBox5.Text == textBox6.Text )
                {
                    if (radioButton1.Checked == true)
                        yetki = "Yönetici";
                    else if (radioButton2.Checked == true)
                        yetki = "Kullanıcı";
                    try
                    {
                        baglanti.Open();
                    SqlCommand guncellekomutu = new SqlCommand("update kullanicilar1 set ad ='" + textBox2.Text + "',soyad='" + textBox3.Text + "',yetki'" + yetki
                        + "',kullaniciadi='" + textBox4.Text + "',parola='" + textBox5.Text + "'where tcno='" + textBox1.Text+"'", baglanti);
                        
                        guncellekomutu.ExecuteNonQuery();
                        baglanti.Close();
                        MessageBox.Show("Kullanıcı bilgileri güncellendi!", "SKY Personel Takip Programı",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    kullanicilari_goster();
                    }
                    catch (Exception hatamsj)
                    {
                        MessageBox.Show(hatamsj.Message,"SKY Personel Takip Programı",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        baglanti.Close();

                    }
                }
                else
                {
                    MessageBox.Show("Yazı rengi kırmızı olan alanları yeniden gözden geçiriniz!", "SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 11)
            {
                bool kayit_arama_durumu = false;
                baglanti.Open();
                SqlCommand selectsorgu = new SqlCommand("select * from kullanicilar1 where tcno='" +
                    textBox1.Text + "'", baglanti);
                SqlDataReader kayitokuma = selectsorgu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayit_arama_durumu = true;
                    SqlCommand deletesorgu = new SqlCommand("delete from kullanicilar1 where tcno='" 
                        + textBox1.Text + "'", baglanti);
                    deletesorgu.ExecuteReader();
                    MessageBox.Show("Kullanıcı kaydı silindi!","SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    baglanti.Close();
                    kullanicilari_goster();
                    topPage1_temizle();
                    break;
                }
                if(kayit_arama_durumu==false)
                    MessageBox.Show("Silinecek kayıt bulunamadı!", "SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                baglanti.Close();
                topPage1_temizle();
            }
            else
                MessageBox.Show("Lütfen 11 karakterden oluşan bir TC Kimlik NO giriniz!", "SKY Personel Takip Programı",
                       MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            topPage1_temizle();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string cinsiyet = ""; 
            bool kayitkontrol = false;

            baglanti.Open();
            SqlCommand selectsorgu = new SqlCommand("select * from personeller where tcno='" + maskedTextBox1.Text + "'", baglanti);
            SqlDataReader kayitokuma = selectsorgu.ExecuteReader();
            while (kayitokuma.Read())
            {
                kayitkontrol = true;
                break;

            }
            baglanti.Close();
            if (kayitkontrol == false)
            {

                if (pictureBox2.Image == null)

                    button6.ForeColor = Color.Red;
                else
                    button6.ForeColor = Color.Black;
                if (maskedTextBox1.MaskCompleted == false)
                    label13.ForeColor = Color.Red;
                else
                    label13.ForeColor = Color.Black;

                if (maskedTextBox2.MaskCompleted == false)
                    label14.ForeColor = Color.Red;
                else
                    label14.ForeColor = Color.Black;
                if (maskedTextBox3.MaskCompleted == false)
                    label15.ForeColor = Color.Red;
                else
                    label15.ForeColor = Color.Black;

                if (comboBox1.Text == "")
                    label17.ForeColor = Color.Red;
                else
                    label17.ForeColor = Color.Black;

                if (comboBox2.Text == "")
                    label18.ForeColor = Color.Red;
                else
                    label18.ForeColor = Color.Black;

                if (pictureBox2.Image != null && maskedTextBox1.MaskCompleted != false && maskedTextBox2.MaskCompleted != false
                    && maskedTextBox3.MaskCompleted != false && comboBox1.Text != "" && comboBox2.Text != "")
                {
                    if (radioButton3.Checked == true)
                        cinsiyet = "Bay";
                    else if (radioButton4.Checked == true)
                        cinsiyet = "Bayan";
                    try
                    {
                        baglanti.Open();
                        SqlCommand eklekomutu = new SqlCommand("insert into personeller values('" +
                            maskedTextBox1.Text + "','" + maskedTextBox2.Text + "','" + maskedTextBox3.Text + "','" +
                            cinsiyet + "','" + comboBox1.Text + "','" + comboBox2.Text + "')", baglanti);
                        eklekomutu.ExecuteNonQuery();
                        baglanti.Close();
                        if (!Directory.Exists(Application.StartupPath + "\\personelresimler"))
                            Directory.CreateDirectory(Application.StartupPath + "\\personelresimler");
                        
                        pictureBox2.Image.Save(Application.StartupPath + "\\personelresimler\\" + 
                            maskedTextBox1.Text + "jpg");

                        MessageBox.Show("Yeni personel kaydı oluşturuldu.", "SKY Personel Takip Programı", MessageBoxButtons.OK,
                            MessageBoxIcon.Exclamation);
                        personelleri_göster();
                        topPage2_temizle();


                    }

                    catch (Exception hatamsj)
                    {
                        MessageBox.Show(hatamsj.Message, "SKY Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();

                    }
                }

                else
                {
                    MessageBox.Show("Yazı rengi kırmızı olan alanları yeniden gözden geçiriniz!", "SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("Girilen TC Kimlik Numarası Dada Önceden Kayıtlıdır!", "SKY Personel Takip Programı",
MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            bool kayit_arama_durumu = false;
            if (maskedTextBox1.Text.Length == 11)
            {
                baglanti.Open();
                SqlCommand selectsorgu = new SqlCommand("select *from personeller where tcno='" + maskedTextBox1.Text + "'", baglanti);
                SqlDataReader kayitokuma = selectsorgu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayit_arama_durumu = true;
                    try
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\personelresimler\\" + 
                            kayitokuma.GetValue(0).ToString() + ".jpg");

                    }
                    catch 
                    {
                        pictureBox2.Image = Image.FromFile(Application.StartupPath + "\\personelresimler\\resimyok.jpg");


                    }
                    maskedTextBox2.Text = kayitokuma.GetValue(1).ToString();
                    maskedTextBox3.Text = kayitokuma.GetValue(2).ToString();
                    if (kayitokuma.GetValue(3).ToString() == "Bay")
                        radioButton3.Checked = true;
                    else 
                        radioButton4.Checked= true;
                    comboBox1.Text = kayitokuma.GetValue(6).ToString();
                    comboBox2.Text = kayitokuma.GetValue(7).ToString();
                    break;





                }
                if(kayit_arama_durumu==false)
                    MessageBox.Show("Aranan Kayıt Bulunamadı!","SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                baglanti.Close();

            }

            else
            {
                MessageBox.Show("11 haneli TC no giriniz!","SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            string cinsiyet = "";

           
            {

                if (pictureBox2.Image == null)

                    button6.ForeColor = Color.Red;
                else
                    button6.ForeColor = Color.Black;
                if (maskedTextBox1.MaskCompleted == false)
                    label13.ForeColor = Color.Red;
                else
                    label13.ForeColor = Color.Black;

                if (maskedTextBox2.MaskCompleted == false)
                    label14.ForeColor = Color.Red;
                else
                    label14.ForeColor = Color.Black;
                if (maskedTextBox3.MaskCompleted == false)
                    label15.ForeColor = Color.Red;
                else
                    label15.ForeColor = Color.Black;

                if (comboBox1.Text == "")
                    label17.ForeColor = Color.Red;
                else
                    label17.ForeColor = Color.Black;

                if (comboBox2.Text == "")
                    label18.ForeColor = Color.Red;
                else
                    label18.ForeColor = Color.Black;

                if (pictureBox2.Image != null && maskedTextBox1.MaskCompleted != false && maskedTextBox2.MaskCompleted != false
                    && maskedTextBox3.MaskCompleted != false && comboBox1.Text != "" && comboBox2.Text != "")
                {
                    if (radioButton3.Checked == true)
                        cinsiyet = "Bay";
                    else if (radioButton4.Checked == true)
                        cinsiyet = "Bayan";
                    try
                    {
                        baglanti.Open();
                        SqlCommand guncellekomutu = new SqlCommand("update personeller set ad='" + 
                            maskedTextBox2.Text + "',soyad='" + maskedTextBox3.Text + "',cinsiyet='" +
                            cinsiyet + "',gorevi='" + comboBox1.Text + "',gorevyeri='" + comboBox2.Text + "'where tcno='"+
                            maskedTextBox1.Text+"'", baglanti);

                        guncellekomutu.ExecuteNonQuery();
                        baglanti.Close();
                      
                        personelleri_göster();
                        topPage2_temizle();


                    }

                    catch (Exception hatamsj)
                    {
                        MessageBox.Show(hatamsj.Message, "SKY Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        baglanti.Close();

                    }
                }

              
        }

    }

        private void button10_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.MaskCompleted == true)
            {
                bool kayit_arama_durumu = false;
                baglanti.Open();
                SqlCommand arama_sorgusu = new SqlCommand("select +from personeller where tcno='" +
                    maskedTextBox1.Text + "'", baglanti);
                SqlDataReader kayitokuma = arama_sorgusu.ExecuteReader();
                while (kayitokuma.Read())
                {
                    kayit_arama_durumu = true;
                    SqlCommand deletesorgu = new SqlCommand("delete +from personeller where tcno='" +
                        maskedTextBox1.Text + "'", baglanti);
                    deletesorgu.ExecuteNonQuery();
                    break;

                }

                if (kayit_arama_durumu == false)
                {
                    MessageBox.Show("Silinecek kayıt bulunamadı!", "SKY Personel Takip Programı",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                    baglanti.Close();
                    personelleri_göster();
                    topPage2_temizle();

                
            }
            else
            {
                MessageBox.Show("Lütfen 11 karakterden oluşan TC kimlik No giriniz!", "SKY Personel Takip Programı",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                topPage2_temizle();


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

            topPage2_temizle();
                    

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 c = new Form3();
            c.Show();
        }
    }
 
    }


    

