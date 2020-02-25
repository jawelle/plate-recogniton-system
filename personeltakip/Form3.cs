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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-U9N4DTG\\SQLEXPRESS;Initial Catalog=PlateRecognition;Integrated Security=True");


        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Frmpersonelcs a = new Frmpersonelcs();
            a.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Hide();
            misafirr a = new misafirr();
            a.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ogr y= new ogr();
           
            y.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 d = new Form2();
            d.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
