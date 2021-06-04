using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageConverter.FormatsImage
{
    class GifToImages
    {
        private Image gifImage;
        private FrameDimension dimension;
        public  int FRAME_COUNT
        {
            get;private set;
        }

        /// <summary>
        /// Конвертор из .Gif в images формат. 
        /// </summary>
        /// <param name="path"></param>
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
    }
}
