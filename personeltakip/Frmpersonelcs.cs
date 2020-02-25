using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class Frmpersonelcs : Form
    {
        Class1 liste = new Class1();
        public Frmpersonelcs()
        {
            InitializeComponent();
        }
        private void yenilelistele()
        {
            string cümle = "select*from kullanici1";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = liste.listele(adtr2, cümle);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btniptal_Click(object sender, EventArgs e)
        {

        }

        private void btnekle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {

        }

        private void Frmpersonelcs_Load(object sender, EventArgs e)
        {
            yenilelistele();
        }

        private void btnekle_Click_1(object sender, EventArgs e)
        {
            string cümle = "insert into kullanici1( TC ,Ad, Soyad,arac_plaka) values (@TC,@Ad,@Soyad,@arac_plaka) ";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@Ad", txtad.Text);
            komut2.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@TC", txttc.Text);
            komut2.Parameters.AddWithValue("@arac_plaka", txtplaka.Text);
            liste.ekle_sil_güncelle(komut2, cümle);
            MessageBox.Show("Kullanıcı kaydedildi");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string cümle = "update kullanici1 set  Ad=@Ad,Soyad=@Soyad,arac_plaka= @arac_plaka WHERE TC=@TC ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Ad", txtad.Text);
            komut2.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@TC", txttc.Text);
            komut2.Parameters.AddWithValue("@arac_plaka", txtplaka.Text);
            liste.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
        }

      

        private void btniptal_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cümle = "delete from kullanici1 where TC='" + satir.Cells["TC"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            liste.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string cümle = "select*from kullanici1 where TC like '%" + txttc.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = liste.listele(adtr2, cümle);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtad.Text = satir.Cells[0].Value.ToString();
            txtsoyad.Text = satir.Cells[1].Value.ToString();
            txttc.Text = satir.Cells[2].Value.ToString();
            txtplaka.Text = satir.Cells[3].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 c = new Form3();
            c.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
