using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_kalkulator_sederhanaPBKK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Masukan Angka 1 dan Angka 2 Terlebih Dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a + b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Masukan Angka 1 dan Angka 2 Terlebih Dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a * b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Masukan Angka 1 dan Angka 2 Terlebih Dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a % b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLHasil.Text = "";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            LBLHasil.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Masukan Angka 1 dan Angka 2 Terlebih Dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a - b;
                this.LBLHasil.Text = c.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Masukan Angka 1 dan Angka 2 Terlebih Dahulu!");
            }
            else
            {
                float a, b, c;
                a = float.Parse(this.textBox1.Text);
                b = float.Parse(this.textBox2.Text);
                c = a / b;
                this.LBLHasil.Text = c.ToString();
            }
        }
    }
}
