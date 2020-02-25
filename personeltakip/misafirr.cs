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
    public partial class misafirr : Form
    {
        Class1 kayit = new Class1();
        public misafirr()
        {
            InitializeComponent();
        }

        private void yenilelistele()
        {
            string cümle = "select*from misafir";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, cümle);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            txtad.Text = satir.Cells[0].Value.ToString();
            txtsoyad.Text = satir.Cells[1].Value.ToString();
            txttc.Text = satir.Cells[2].Value.ToString();
            txtplaka.Text = satir.Cells[3].Value.ToString();

        }

        private void misafirr_Load(object sender, EventArgs e)
        {
            yenilelistele();
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            string cümle = "insert into misafir ( TC,Ad, Soyad,AraçPlaka) values (@TC,@Ad,@Soyad,@AraçPlaka) ";
            SqlCommand komut2 = new SqlCommand();

            komut2.Parameters.AddWithValue("@Ad", txtad.Text);
            komut2.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@TC", txttc.Text);
            komut2.Parameters.AddWithValue("@AraçPlaka", txtplaka.Text);
            kayit.ekle_sil_güncelle(komut2, cümle);
            MessageBox.Show("Kullanıcı eklendi");
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string cümle = "update misafir set  Ad=@Ad,Soyad=@Soyad,AraçPlaka= @AraçPlaka WHERE TC=@TC ";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@Ad", txtad.Text);
            komut2.Parameters.AddWithValue("@Soyad", txtsoyad.Text);
            komut2.Parameters.AddWithValue("@TC", txttc.Text);
            komut2.Parameters.AddWithValue("@AraçPlaka", txtplaka.Text);
            kayit.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            string cümle = "delete from misafir where TC='" + satir.Cells["TC"].Value.ToString() + "'";
            SqlCommand komut2 = new SqlCommand();
            kayit.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            yenilelistele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string cümle = "select*from misafir where TC like '%" + txttc.Text + "%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            dataGridView1.DataSource = kayit.listele(adtr2, cümle);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 c = new Form3();
            c.Show();
        }
    }
}
