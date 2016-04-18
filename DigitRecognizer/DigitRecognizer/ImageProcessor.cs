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
    /// Contains methods used to process images
    /// </summary>
    class ImageProcessor
    {
        /// <summary>
        /// Converts image to a format used by the neural network
        /// </summary>
        /// <param name="image">Reference to a Bitmap</param>
        public void PrepareImage(ref System.Drawing.Bitmap image)
        {
            Binarize(ref image);
            Crop(ref image);
            Resize(ref image);
        }
        /// <summary>
        /// Converts an image to black and white
        /// </summary>
        /// <param name="image">Reference to a Bitmap</param>
        private void Binarize(ref System.Drawing.Bitmap image)
        {
            Threshold filter = new Threshold(100);

            try
            {
                ConvertToGrayscale(ref image); //Conversion to grayscale to match Threshold arguments
                image = filter.Apply(image);
            }
            catch (Exception) { }
        }
        /// <summary>
        /// Converts an image to grayscale
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
        /// Crops the image's borders
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
        /// Resizes an image to 7x10 px
        /// </summary>
        /// <param name="image">Reference to a Bitmap</param>
        private void Resize(ref System.Drawing.Bitmap image)
        {
            ResizeNearestNeighbor filter = new ResizeNearestNeighbor(7, 10);

            try
            {
                image = filter.Apply(image);
            }
            catch (Exception) { }
        }
    }
}
