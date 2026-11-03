using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinAppI_307A
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if ((txtBox1).Text.Contains(","))
            {
                btnDot.Enabled = false;
            }
            else
            {
                btnDot.Enabled = true;
            }

            //if ((txtBox1.Text.IndexOf(",") >= 1))
            //{
            //    btnDot.Enabled = false;
            //}
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void btnDot_Click(object sender, EventArgs e)
        {

        }
        private void btnNumberAction_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if ((txtBox1.Text.IndexOf(",") == 1))
            {
                
            }
            txtBox1.Text += btn.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            n1 = txtBox1.Text;
            txtBox1.Text.Remove;


        }

        private void btnMinus_Click(object sender, EventArgs e)
        {

        }

        private void btnDivision_Click(object sender, EventArgs e)
        {

        }

        private void btnMultip_Click(object sender, EventArgs e)
        {

        }

        private void btnBackSpace_Click(object sender, EventArgs e)
        {

        }

        private void btnClrEntry_Click(object sender, EventArgs e)
        {

        }

        private void btnClr_Click(object sender, EventArgs e)
        {

        }
    }
}
