using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interest_Calculator
{
    public partial class Form1 : Form
    {

        double amount;
        double months;
        double interest;
        double totalInterest;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            interest = Convert.ToDouble(txtInterest.Text);
            months = Convert.ToDouble(txtMonths.Text);
            amount = Convert.ToDouble(txtAmount.Text);

            interest = interest / 100;

            totalInterest = amount * (Math.Pow(1 + interest, months) - 1);
            label4.Text = totalInterest.ToString("#.##");
        }
    }
}
