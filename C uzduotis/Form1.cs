using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_uzduotis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            string[] masyvas = textBox1.Text.Split(',');
            int suma = 0;
            if (masyvas.Length == 10)
            {
                richTextBox1.Text = "Jusu masyvas = [ ";
                for (int i = 0; i < masyvas.Length; i++)
                {

                    richTextBox1.Text += masyvas[i].ToString() + " ";
                    suma = suma + Convert.ToInt32(masyvas[i]);
                }
                richTextBox1.Text += "]";
                richTextBox1.Text += Environment.NewLine + "Jusu ivestu skaiciu suma= " + suma;
            }
            else MessageBox.Show("Ivedete maziau arba daugiau skaiciu  negu 10!");
        }

            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double parsedValue;
            if (!double.TryParse(textBox2.Text, out parsedValue))
            {
                MessageBox.Show("Klaidingai ivestas skaicius");
                return;
            }
            int a = Convert.ToInt32(textBox2.Text);
            int tarpai = 35;
            int zvaigzdes = 1;
            richTextBox2.Text = ("");
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < tarpai; j++)
                {
                    richTextBox2.Text+=(" ");
                }
                for (int j = 0; j < zvaigzdes; j++)
                {
                    richTextBox2.Text += ("* ");
                }
                richTextBox2.Text += Environment.NewLine;
                zvaigzdes++;
                tarpai--;
            }


        }
    }
}
