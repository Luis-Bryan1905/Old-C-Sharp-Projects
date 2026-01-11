using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Caesar_Cipher_encryption
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
                {
        string origMessage = normaltext.Text;
        int shiftNum = Int32.Parse(textBox3.Text);

        cyphertext.Text = doEncryption(origMessage, shiftNum);

                }
        private static string doEncryption(string words, int shiftNo)
        {
            char[] buffer = words.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                // each letter will be seperated and then changed

                char Letter = buffer[i];

                // shift the letters according to the shift no variable

                Letter = (char)(Letter + shiftNo);

                // Subtract 26 on overflow
                // Add 26 on Underflow

                if (Letter > 'z')
                {
                    Letter = (char)(Letter - 26);
                }
                else if (Letter < 'a')
                {
                    Letter = (char)(Letter + 26);
                }
                //Store

                buffer[i] = Letter;
            }

            return new string(buffer);

            }
        }
    }

