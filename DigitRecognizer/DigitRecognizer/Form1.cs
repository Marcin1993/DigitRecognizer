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
        NeuralNetwork network;

        //Console for debuging purposes
        [System.Runtime.InteropServices.DllImport("kernel32.dll")]
        private static extern bool AllocConsole();

        public Form1()
        {
            AllocConsole(); //Console for debuging purposes      

            openDialog = new OpenFileDialog();
            openDialog.Filter = "Image files (*.bmp, *jpg, *jpeg, *png, *dib)|*.bmp; *jpg; *jpeg; *png; *dib";
            openDialog.FilterIndex = 1;

            InitializeComponent();

            imageProcessor = new ImageProcessor();
            network = new NeuralNetwork();
            network.Learn();
            //network.LoadNetwork();
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
            imageProcessor.PrepareImage(ref image);
            OutputImageView.Image = image;
            OutputTextView.Text = "Recognized digit: " + network.Compute(image);
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
                InputImageView.Image = image;
            }
            catch (ArgumentException e) 
            {
                OutputTextView.Text = e.Message;
            }
        }
    }
}
