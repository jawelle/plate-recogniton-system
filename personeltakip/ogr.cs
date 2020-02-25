using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class ogr : Form
    {
        Class1 liste = new Class1();
        public ogr()
        {
            InitializeComponent();
        }
        private void yenilelistele()
        {
            string cümle = "select*from ogrenci";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = liste.listele(adtr2, cümle);
        }
        private void yenilelistele1()
        {
            string cümle = "select*from ogrzaman";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = liste.listele(adtr2, cümle);
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cümle = "update ogrenci set TC=@TC, Ad=@Ad,Soyad=@Soyad,AraçPlaka= @AraçPlaka WHERE ogrenci_numarasi=@ogrenci_numarasi ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ogrenci_numarasi", txtogrno.Text);
            komut2.Parameters.AddWithValue("@Ad", txtad.Text);
            komut2.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@TC", txttc1.Text);
            komut2.Parameters.AddWithValue("@AraçPlaka", txtplaka.Text);
            liste.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtogrno.Text = satir.Cells[0].Value.ToString();
            txtad.Text = satir.Cells[1].Value.ToString();
            txtsoyad.Text = satir.Cells[2].Value.ToString();
            txttc1.Text = satir.Cells[3].Value.ToString();
            txtplaka.Text = satir.Cells[4].Value.ToString();
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cümle = "delete from ogrenci where ogrenci_numarasi='" + satir.Cells["ogrenci_numarasi"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            liste.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string cümle = "insert into ogrenci(ogrenci_numarasi,TC,Ad,Soyad,AraçPlaka ) values (@ogrenci_numarasi,@TC,@Ad,@Soyad,@AraçPlaka) ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@ogrenci_numarasi", txtogrno.Text);
            komut2.Parameters.AddWithValue("@Ad", txtad.Text);
            komut2.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@TC", txttc1.Text);
            komut2.Parameters.AddWithValue("@AraçPlaka", txtplaka.Text);
            liste.ekle_sil_güncelle(komut2, cümle);
            MessageBox.Show("Kullanıcı kaydedildi");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string cümle = "select*from ogrenci where ogrenci_numarasi like '%" + txtogrno.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = liste.listele(adtr2, cümle);
        }

        private void ogr_Load(object sender, EventArgs e)
        {
            yenilelistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string cümle = "select*from ogrzaman where AraçPlaka like '%" + txtplaka.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = liste.listele(adtr2, cümle);
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 c = new Form3();
            c.Show();
        }
    }
}
