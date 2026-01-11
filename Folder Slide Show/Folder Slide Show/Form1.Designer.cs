using System.Windows.Forms;

namespace Folder_Slide_Show
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private Button playstop;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.playstop = new System.Windows.Forms.Button();
            this.filename = new System.Windows.Forms.Label();
            this.image = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.image)).BeginInit();
            this.SuspendLayout();
            // 
            // playstop
            // 
            this.playstop.Location = new System.Drawing.Point(347, 394);
            this.playstop.Name = "playstop";
            this.playstop.Size = new System.Drawing.Size(75, 23);
            this.playstop.TabIndex = 0;
            this.playstop.Text = "play";
            this.playstop.UseVisualStyleBackColor = true;
            this.playstop.Click += new System.EventHandler(this.playstop_Click);
            // 
            // filename
            // 
            this.filename.AutoSize = true;
            this.filename.Location = new System.Drawing.Point(134, 428);
            this.filename.Name = "filename";
            this.filename.Size = new System.Drawing.Size(35, 13);
            this.filename.TabIndex = 1;
            this.filename.Text = "label1";
            // 
            // image
            // 
            this.image.Location = new System.Drawing.Point(200, 1);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(390, 357);
            this.image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.image.TabIndex = 2;
            this.image.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.image);
            this.Controls.Add(this.filename);
            this.Controls.Add(this.playstop);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Playstop;
        private System.Windows.Forms.Label filename;
        private System.Windows.Forms.PictureBox image;
        private System.Windows.Forms.Timer timer1;
    }
}

