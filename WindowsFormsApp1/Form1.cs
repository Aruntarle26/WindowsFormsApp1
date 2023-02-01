using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            double basic = Convert.ToDouble(txtBasicSal.Text);
            double ta = basic * .20;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtName.Text+" "+ txtNumber.Text+" "+ txtBasicSal.Text);
           
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtBasicSal.Clear();
            txtNumber.Clear();
            txtHRA.Clear();
            txtDA.Clear();
            txtTA.Clear();
            txtTotalSal.Clear();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double basic = Convert.ToDouble(txtBasicSal.Text);
            double hra = basic * .15;
            double ta = basic * .12;
            double da = basic * .17;
            double pf = basic * 0.20;
            double totalsal = (basic + hra + da + ta)-pf;
            txtHRA.Text = hra.ToString();
            txtDA.Text = da.ToString();
            txtTA.Text = ta.ToString();
            txtTotalSal.Text = totalsal.ToString();
        }

        private void txtHRA_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBasicSal_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txtNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDA_TextChanged(object sender, EventArgs e)
        {
            double basic = Convert.ToDouble(txtBasicSal.Text);
            double da = basic * 0.12;
        }

        private void txtTotalSal_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
