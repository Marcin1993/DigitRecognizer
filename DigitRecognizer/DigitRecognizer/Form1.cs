using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitRecognizer
{
    public partial class Form1 : Form
    {
        Bitmap image;
        OpenFileDialog openDialog;
        ImageProcessor imageProcessor;

        public Form1()
        {
            imageProcessor = new ImageProcessor();
            openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.bmp, *jpg, *jpeg, *png, *dib)|*.bmp; *jpg; *jpeg; *png; *dib";
            openDialog.FilterIndex = 1;

            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            getImageFromDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getImageFromDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Recognized digit: 8====D";
            imageProcessor.PrepareImage(ref image);
            pictureBox2.Image = image;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by:\n\nDawid Kuczyński\nMarcin Okularczyk",
                            "About", MessageBoxButtons.OK);
        }

        private void getImageFromDialog()
        {
            openDialog.ShowDialog();
            try
            {
                image = (Bitmap)Image.FromFile(openDialog.FileName);
                pictureBox1.Image = image;
            }
            catch (ArgumentException e) 
            {
                textBox1.Text = e.Message;
            }
        }
    }

}
