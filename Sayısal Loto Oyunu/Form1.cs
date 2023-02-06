using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sayısal_Loto_Oyunu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int dogru = 0;
            int yanlis = 0;

            Random rast = new Random();
            int s1, s2, s3, s4;

            s1 = rast.Next(1, 5);
            s2 = rast.Next(1, 5);
            s3 = rast.Next(1, 5);
            s4 = rast.Next(1, 5);

            label1.Text = s1.ToString();
            label2.Text = s2.ToString();
            label3.Text = s3.ToString();
            label4.Text = s4.ToString();

            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

            // Sayı 1
            if(maskedTextBox1.Text == label1.Text)
            {
                maskedTextBox1.BackColor = Color.LightGreen;
                dogru++;
            }
            else
            {
                maskedTextBox1.BackColor = Color.IndianRed;
                yanlis++;
            }

            // Sayı 2
            if (maskedTextBox2.Text == label2.Text)
            {
                maskedTextBox2.BackColor = Color.LightGreen;
                dogru++;
            }
            else
            {
                maskedTextBox2.BackColor = Color.IndianRed;
                yanlis++;
            }

            // Sayı 3
            if (maskedTextBox3.Text == label3.Text)
            {
                maskedTextBox3.BackColor = Color.LightGreen;
                dogru++;
            }
            else
            {
                maskedTextBox3.BackColor = Color.IndianRed;
                yanlis++;
            }

            // Sayı 4
            if (maskedTextBox4.Text == label4.Text)
            {
                maskedTextBox4.BackColor = Color.LightGreen;
                dogru++;
            }
            else
            {
                maskedTextBox4.BackColor = Color.IndianRed;
                yanlis++;
            }

            label9.Text = dogru.ToString();
            label10.Text = yanlis.ToString();

            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label10.Visible = true;
                  
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
