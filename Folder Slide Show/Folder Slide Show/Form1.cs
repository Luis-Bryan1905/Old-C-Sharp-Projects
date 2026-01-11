using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Folder_Slide_Show
{
    public partial class Form1 : Form
    {
        int counter = 1;
        FolderBrowserDialog fbd = new FolderBrowserDialog();
        bool playing = false;

        public Form1()

        {
            InitializeComponent();
        }

        void playstop_Click(object sender, EventArgs e)
        {
            if (!playing)
            {
                DialogResult result = fbd.ShowDialog();
                playstop.Text = "stop";
                timer1.Start();
                playing = true;
            }
            else
            {
                playstop.Text = "play";
                playing = false;
                timer1.Stop();
                
            }
        }

        void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            string[] images = Directory.GetFiles(fbd.SelectedPath, "*.*");

            if (counter > images.Length - 1)
            {
                counter = 0;
            }

            image.Image = Image.FromFile(images[counter]);
            filename.Text = images[counter];
        }
    }
    }

