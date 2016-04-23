using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using AForge.Neuro;
using AForge.Neuro.Learning;

namespace DigitRecognizer
{
    /// <summary>
    /// Artificial neural network implementation
    /// </summary>
    class NeuralNetwork
    {
        private ActivationNetwork network;
        private BackPropagationLearning teacher;
        private double[][] input;
        private double[][] output;

        public NeuralNetwork()
        {
            network = new ActivationNetwork(
                new SigmoidFunction(2), //activation function
                200, //neurons in the input layer
                8,  //neurons in the hidden layer
                10); //neurons in the output layer

            network.Randomize();
            teacher = new BackPropagationLearning(network);
        }  

        /// <summary>
        /// Network learning
        /// </summary>
        public void Learn()
        {
            PrepareTrainingData();

            double err = 1;

            while (err >= 0.001)
            {
                err = teacher.RunEpoch(input, output);
                Console.WriteLine("Epoch finished\terror: " + err);
            }
            SaveNetwork();
        }

        /// <summary>
        /// Save network to file
        /// </summary>
        public void SaveNetwork()
        {
            network.Save("..\\..\\network\\network.dat");
        }

        /// <summary>
        /// Load network from file
        /// </summary>
        public void LoadNetwork()
        {
            network = (ActivationNetwork)Network.Load("..\\..\\network\\network.dat");
            network.SetActivationFunction(new SigmoidFunction(2));
        }

        /// <summary>
        /// Prepare input and output arrays for learning
        /// </summary>
        private void PrepareTrainingData()
        {
            ImageProcessor imgProc = new ImageProcessor();
            String[] fileArray = Directory.GetFiles("..\\..\\data");
            
            input = new double[fileArray.Length][];
            output = new double[fileArray.Length][];

            Bitmap image;
            int number;

            ShuffleArray(fileArray);
            
            for (int i = 0; i < fileArray.Length; i++)
            {
                image = new Bitmap(fileArray[i]);
                imgProc.PrepareImage(ref image);

                input[i] = imgProc.GetVector(image);
                output[i] = new double[10];

                number = (int)Char.GetNumericValue(fileArray[i], 15);
                output[i][number] = 1;
            }
        }

        /// <summary>
        /// Shuffle a String array using Fisher-Yates shuffle
        /// </summary>
        /// <param name="array">Array of Strings</param>
        private void ShuffleArray(String[] array)
        {
            Random r = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                int index = (int)(r.NextDouble() * (array.Length - i));

                String temp = array[index];
                array[index] = array[i];
                array[i] = temp;
            }
        }

        /// <summary>
        /// Compute the output for the given Bitmap
        /// </summary>
        /// <param name="image">Bitmap to recognize</param>
        /// <returns>Recognized digit</returns>
        public int Compute(Bitmap image)
        {
            ImageProcessor imgProc = new ImageProcessor();

            double[] input = imgProc.GetVector(image);
            double[] output = network.Compute(input);

            double max = -1;
            int result = -1;

            for(int i = 0; i < 10 ; i++)
            {
                if(max < output[i])
                {
                    max = output[i];
                    result = i;
                }
            }

            return result;
        }
    }
}