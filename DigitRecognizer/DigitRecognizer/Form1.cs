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

namespace DigitRecognizer
{
    public partial class Form1 : Form
    {
        Bitmap image;
        OpenFileDialog openDialog;
        FolderBrowserDialog openFolder;
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

            openFolder = new FolderBrowserDialog();
            InitializeComponent();

            imageProcessor = new ImageProcessor();
            network = new NeuralNetwork();
            //network.Learn();
            network.LoadNetwork();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getImageFromDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            imageProcessor.PrepareImage(ref image);
            outputImageView.Image = image;
            outputTextView.Text = "Recognized digit: " + network.Compute(image);
        }

        private void getImageFromDialog()
        {
            openDialog.ShowDialog();
            try
            {
                image = (Bitmap)Image.FromFile(openDialog.FileName);
                inputImageView.Image = image;
            }
            catch (ArgumentException e) 
            {
                outputTextView.Text = e.Message;
            }
        }

        //openFolderButton
        private void button1_Click_1(object sender, EventArgs e)
        {
            openFolder.ShowDialog();

            try
            {
                String[] fileArray = Directory.GetFiles(openFolder.SelectedPath);
                Bitmap image;
                int[] digitCount = new int[10]; //digit occurrance count
                int[] correctCount = new int[10]; //count of correct guesses for specific digits
                int correct = 0; //all correct guesses of all digits
                int number;

                //Count how many times a digit occurred and correct guesses

                for (int i = 0; i < fileArray.Length; i++)
                {
                    number = (int)Char.GetNumericValue(fileArray[i], fileArray[i].Length - 10);
                    ++digitCount[number];

                    image = (Bitmap)Image.FromFile(fileArray[i]);
                    imageProcessor.PrepareImage(ref image);

                    if (network.Compute(image) == number)
                    {
                        ++correctCount[number];
                        ++correct;
                    }
                }

                //Show statistics

                statisticsBox.ResetText();

                float percentage;

                for (int i = 0; i < 10; i++)
                {
                    percentage = ((float)correctCount[i] / digitCount[i]) * 100;

                    statisticsBox.AppendText("Digit: " + i + "\tCount: " + digitCount[i] +
                        "\tCorrect: " + correctCount[i] + "\tPercentage: " +
                        percentage + "\n");
                }

                percentage = (float)correct / fileArray.Length * 100;

                statisticsBox.AppendText("All: " + fileArray.Length + "\tCorrect: " + correct +
                    "\tPercentage: " + percentage);
            }
            catch(Exception)
            {

            }
        }
    }
}