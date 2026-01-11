using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2012_Meme_Maker
{
    public partial class Form1 : Form
    {
        OpenFileDialog openImage;
        string imageFile;

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            topLabel.Text = textBox1.Text;
            topLabel.MaximumSize = new Size(preview.Width, 200);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            bottomLabel.Text = textBox2.Text;
            bottomLabel.MaximumSize = new Size(preview.Width, 200);
        }

        private void Open_Click(object sender, EventArgs e)
        {
            openImage = new OpenFileDialog();
            openImage.InitialDirectory = "c:\\";
            openImage.Filter = "Image files (*.jpg, *.jpeg, *.png, ) | *.jpg; *.jpeg; *.png; *.gif";
            openImage.FilterIndex = 2;
            openImage.RestoreDirectory = true;

            if (openImage.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    preview.Image = Image.FromFile(openImage.FileName);
                    imageFile = openImage.FileName;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not real file from disk. Orginal error; " + ex.Message);
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string firstText = topText.Text;
            string secondText = bottomLabel.Text;

            Bitmap bitmap = (Bitmap)Image.FromFile(imageFile);

            RectangleF TopSize = new RectangleF(0, 10, bitmap.Width, 400);
            RectangleF BottomSize = new RectangleF(0, 10, bitmap.Height, -100);

            SaveFileDialog saveImage = new SaveFileDialog();
            saveImage.FileName = "*";
            saveImage.DefaultExt = "bmp";
            saveImage.ValidateNames = true;
            saveImage.Filter = "Bitmap Image (.bmp)|*.bmp| Gif Image (.gif)|*.gif |JPEG Image (.jpg)|*.jpeg| PNG Image (.png)|*.png";

            if (saveImage.ShowDialog() == DialogResult.OK)
            {

                using (Graphics graphics = Graphics.FromImage(bitmap))
                {
                    using (Font memeFont = new Font("Impact", 24, FontStyle.Bold, GraphicsUnit.Point))
                    {
                        graphics.DrawString(firstText, memeFont, Brushes.White, TopSize);
                        graphics.DrawString(secondText, memeFont, Brushes.White, BottomSize);
                    }
                }

                bitmap.Save(saveImage.FileName);
            }
        }
    }
}
