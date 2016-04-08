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

        OpenFileDialog openDialog;

        public Form1()
        {
            openDialog = new OpenFileDialog();
            openDialog.Filter = "Bitmap (.bmp)|*.bmp";
            openDialog.FilterIndex = 1;

            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
            pictureBox1.ImageLocation = openDialog.FileName;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openDialog.ShowDialog();
            pictureBox1.ImageLocation = openDialog.FileName;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "8====D";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Created by:\n\nDawid Kuczyński\nMarcin Okularczyk",
                            "About", MessageBoxButtons.OK);
        }
    }

}
