using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageConverter.FormatsImage
{
    class GifToImages : IDisposable
    {
        private Image gifImage;
        private FrameDimension dimension;
        public int FRAME_COUNT
        {
            get;private set;
        }
        public GifToImages(string path)
        {
            gifImage = Image.FromFile(path); 
            dimension = new FrameDimension(gifImage.FrameDimensionsList[0]);
            FRAME_COUNT = gifImage.GetFrameCount(dimension);
        }
        public Image GetFrame(int index)
        {
            gifImage.SelectActiveFrame(dimension, index);  
            return gifImage.Clone() as Image;  
        }
 

        public void Dispose()
        {
            gifImage.Dispose();
            FRAME_COUNT = 0; dimension = null;
        }
    }
}
