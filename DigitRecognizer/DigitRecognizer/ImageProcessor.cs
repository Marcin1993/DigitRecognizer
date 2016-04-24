using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using AForge.Imaging;
using AForge.Imaging.Filters;

namespace DigitRecognizer
{
    /// <summary>
    /// Image Processing
    /// </summary>
    class ImageProcessor
    {
        /// <summary>
        /// Convert an image to a format used by the neural network
        /// </summary>
        /// <param name="image">Reference to a Bitmap</param>
        public void PrepareImage(ref System.Drawing.Bitmap image)
        {
            Binarize(ref image);
            Crop(ref image);
            Resize(ref image);
        }

        /// <summary>
        /// Convert an image to black and white
        /// </summary>
        /// <param name="image">Reference to a Bitmap</param>
        private void Binarize(ref System.Drawing.Bitmap image)
        {
            //BradleyLocalThresholding filter = new BradleyLocalThresholding();
            Threshold filter = new Threshold(250);
           
            try
            {
                ConvertToGrayscale(ref image); //Conversion to grayscale to match Threshold arguments
                image = filter.Apply(image);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Convert an image to grayscale
        /// </summary>
        /// <param name="image">Reference to a Bitmap</param>
        private void ConvertToGrayscale(ref System.Drawing.Bitmap image)
        {
            Grayscale filter = new Grayscale(0.2125, 0.7154, 0.0721);

            try
            {
                image = filter.Apply(image);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Crop the image's borders
        /// </summary>
        /// <param name="image">Reference to a Bitmap</param>
        private void Crop(ref System.Drawing.Bitmap image)
        {
            Shrink filter = new Shrink(Color.White);

            try
            {
                image = filter.Apply(image);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Resize an image to 10x15 px
        /// </summary>
        /// <param name="image">Reference to a Bitmap</param>
        private void Resize(ref System.Drawing.Bitmap image)
        {
            ResizeNearestNeighbor filter = new ResizeNearestNeighbor(10, 15);

            try
            {
                image = filter.Apply(image);
            }
            catch (Exception) { }
        }

        /// <summary>
        /// Return pixel vector from Bitmap
        /// </summary>
        /// <param name="image">Bitmap to convert</param>
        /// <returns><b>int[] vector</b> bitmap pixel vector</returns>
        public double[] GetVector(System.Drawing.Bitmap image)
        {
            double[] vector = new double[image.Width * image.Height];
            int currentVectorIndex = 0;

            for(int i = 0; i < image.Height; i++)
            {
                for(int j = 0; j < image.Width; j++)
                {
                    if(image.GetPixel(j, i).ToArgb() == Color.Black.ToArgb())
                    {
                        vector[currentVectorIndex] = 1;
                    }
                    else
                    {
                        vector[currentVectorIndex] = 0;
                    }
                    ++currentVectorIndex;
                }
            }
            return vector;
        }
    }
}