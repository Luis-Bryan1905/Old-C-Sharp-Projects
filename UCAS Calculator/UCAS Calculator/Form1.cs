using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCAS_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String grade = textBox1.Text;
            grade = grade.ToLower();
            if (grade == "pp")
            {
                label3.Text = "80";
            }
            if(grade == "mp")
            {;
                label3.Text = "120";
            }
            if(grade == "mm")
            {;
                label3.Text = "160";
            }
            if(grade == "dm")
            {;
                label3.Text = "200";
            }
            if(grade == "dd")
            {
                label3.Text = "240";
            }
            else
                 {
                MessageBox.Show ("Enter a Valid Grade");
                 }

            
        }
    }
}
