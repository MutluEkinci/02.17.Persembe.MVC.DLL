using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL.DAL;
using Model.Model;
using Kutuphane;
namespace WinApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnTersCevir_Click(object sender, EventArgs e)
        {
            Metin metin = new Metin();

            label1.Text = metin.TersÇevir(textBox1.Text);
        }

        private void btnEko_Click(object sender, EventArgs e)
        {
            Metin metin = new Metin();
            label1.Text = metin.Eko(5, textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Data data = new Data();
            dataGridView1.DataSource = data.UrunGetir();
        }
    }
}
