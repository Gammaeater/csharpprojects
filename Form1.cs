using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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
        int prev;
        private void GetDigits(object sender, EventArgs e)
        {
            if (status == true)
            {
                prev = int.Parse(lblScreen.Text);
                lblScreen.Text = "";
            }

            lblScreen.Text += ((Button)sender).Text;
        }
        string op;
        bool status = false;
        private void getOperator(object sender, EventArgs e)
        {
            op = ((Button)sender).Text;
            status = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (op == "+")
            {
                lblScreen.Text = (prev + int.Parse(lblScreen.Text)).ToString();
            }

            if (op == "-")
            {
                lblScreen.Text = (prev - int.Parse(lblScreen.Text)).ToString();
            }

            if (op == "*")
            {
                lblScreen.Text = (prev * int.Parse(lblScreen.Text)).ToString();



            }


            if (op == "%")
            {
                lblScreen.Text = (prev%int.Parse(lblScreen.Text)).ToString();



            }


            if (op == "/")
            {
                lblScreen.Text = (prev / int.Parse(lblScreen.Text)).ToString();



            }

            status = true;



        }


    }
}
