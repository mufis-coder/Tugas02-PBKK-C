using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aplikasi_sederhanapbkk
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

        private void button1_Click(object sender, EventArgs e)
        {
            
            if(string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Isi Nama Terlebih Dahulu!");
            }
            else
            {
                string msg = "Hello, World! " + textBox1.Text;
                string msg1 = "Aplikasi yang telah dibuat di .NET:";
                string msg2 = "- Simple Application with .NET (tugas PBKK)";
                string msg3 = "- Simple Kalkulator (tugas PBKK)";
                MessageBox.Show(msg + System.Environment.NewLine + 
                    msg1 + System.Environment.NewLine +
                    msg2 + System.Environment.NewLine +
                    msg3);
            }
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
