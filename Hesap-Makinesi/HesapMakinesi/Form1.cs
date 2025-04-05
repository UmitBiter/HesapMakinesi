using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HesapMakinesi
{
    public partial class Form1 : Form
    {
        string islem;
        double sonuc = 0;
        bool kontrol = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (kontrol)
            {
                kontrol = false;
                textBox1.Text = "";
            }
            Button b = (Button)sender;
            textBox1.Text += b.Text;
        }
        
        private void button10_Click(object sender, EventArgs e)
        {            
            Button b = (Button)sender;
            islem = Convert.ToString(b.Text);
            sonuc = Convert.ToDouble(textBox1.Text);
            textBox1.Text = " ";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            switch (islem)
            {
                case "+":
                    textBox1.Text = (sonuc + Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (sonuc - Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (sonuc * Convert.ToDouble(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (sonuc / Convert.ToDouble(textBox1.Text)).ToString();
                    break;

            }
            kontrol = true;
            sonuc = 0;

        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double current = double.Parse(textBox1.Text);
                double percentage = current / 100;
                textBox1.Text = percentage.ToString();
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0"; // Ekranı sıfırlar
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";  // Ekranı sıfırlar
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > 1)
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1); // Son karakteri siler
            else
                textBox1.Text = "0";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double current = double.Parse(textBox1.Text);
                if (current != 0)
                {
                    textBox1.Text = (1 / current).ToString();
                }
                else
                {
                    MessageBox.Show("Sıfıra bölme hatası!");
                }
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double current = double.Parse(textBox1.Text);
                textBox1.Text = (current * current).ToString(); // x²
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double current = double.Parse(textBox1.Text);
                if (current >= 0)
                {
                    textBox1.Text = Math.Sqrt(current).ToString(); // √x
                }
                else
                {
                    MessageBox.Show("Negatif sayının karekökü alınamaz!");
                }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                double current = double.Parse(textBox1.Text);
                textBox1.Text = (-current).ToString(); // İşaret değiştir
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
            {
                textBox1.Text += ","; // Sayıya virgül ekler
            }
        }
    }
}
