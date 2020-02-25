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
namespace personeltakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Veri tabanı dosya yolu ve provider nesnesinin belirlenmesi
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U9N4DTG\\SQLEXPRESS;Initial Catalog=PlateRecognition;Integrated Security=True");

        //Formlar arası veri aktarımında kullanılacak değişkenler
        public static string tcno, adi, soyadi, yetki;

        //Yerel yani yalnızca bu formda geçerli olacak değişkenler
        int hak = 3; bool durum = false;

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
          

            this.Text = "Kullanıcı Girişi";
            this.AcceptButton = button1; this.CancelButton = button2;
            label5.Text = Convert.ToString(hak);
            radioButton1.Checked = true;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedToolWindow;
        }
        private void button1_Click(object sender, EventArgs e)
        {
           


            if (hak != 0)
            { 
            baglanti.Open();
                SqlCommand selectsorgu = new SqlCommand("select *from kullanicilar1",baglanti);
                SqlDataReader kayitokuma = selectsorgu.ExecuteReader();
                while(kayitokuma.Read())
                {
                    if(radioButton1.Checked==true)
                    {
                        if (kayitokuma["kullaniciadi"].ToString()==textBox1.Text&& kayitokuma["parola"].ToString()==textBox2.Text&&kayitokuma["yetki"].ToString()=="Yönetici")
                        {
                            durum = true;
                            tcno = kayitokuma.GetValue(0).ToString();
                            adi = kayitokuma.GetValue(1).ToString();
                            soyadi = kayitokuma.GetValue(2).ToString();
                            yetki = kayitokuma.GetValue(3).ToString();
                            this.Hide();
                          
                            Form3 a= new Form3();

                            a.Show();


                            break;
                        }
                    }
                    if (radioButton2.Checked == true)
                    {
                        if (kayitokuma["kullaniciadi"].ToString() == textBox1.Text && kayitokuma["parola"].ToString() == textBox2.Text && kayitokuma["yetki"].ToString() == "Kullanıcı")
                        {
                            durum = true;
                            tcno = kayitokuma.GetValue(0).ToString();
                            adi = kayitokuma.GetValue(1).ToString();
                            soyadi = kayitokuma.GetValue(2).ToString();
                            yetki = kayitokuma.GetValue(3).ToString();
                            this.Hide();
                            //Form3 frm3 = new Form3();
                            //frm3.Show();
                            break;
                        }
                    }
                }
                if (durum == false)
                    hak--;
                baglanti.Close();
            }
            label5.Text = Convert.ToString(hak);
            if(hak==0)
            {
                button1.Enabled = false;
                MessageBox.Show("Giriş hakkı kalmadı", "SKY Personel Takip Programı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }
        private void label1_Click(object sender, EventArgs e)
        {


        }
    }
}
