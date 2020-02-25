using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakip
{
    public partial class Form4 : Form
    {
        public bool Tanimli;

        public String Okunan_Plaka = "AA";

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Plaka_Kontrol(textBox1.Text);

        }

        public bool Plaka_Kontrol(String plaka)
        {
            Tanimli = Okunan_Plaka.Equals(plaka);

            textBox2.Text = Tanimli.ToString();

            return Tanimli;
        }

        public void Kamera_Calistir()
        {

        }
    }
}
