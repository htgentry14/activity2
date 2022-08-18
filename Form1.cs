using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppactivity2converter
{
    public partial class Form1 : Form
    {
        private object display_txt;
        private int i;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (toUSD.Checked == true)
            {
                lblEuro.Text = "enter USD value";
                txtAmount.Focus();
                int conver = i * 115;
                display_txt.Text = "Converted Amount : " + conver + "\t Euro";
            }

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (toEuro.Checked == true)
            {
                lblEuro.Text = "enter euro to dollar value";
                txtAmount.Focus();
                int conver = i / 103;
                display_txt.Text = "Converted Amount : " + conver + "\t $";

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (toUSD.Checked == true)
            {
                MessageBox.Show("USD: " + (double.Parse(txtAmount1.Text) * double.Parse(txtAmount.Text)));
            }
            else if (toEuro.Checked == true)
            {
                MessageBox.Show("Euro: " + (double.Parse(txtAmount1.Text) * double.Parse(txtAmount.Text)));
            }
          
            }
        }

      
    }

