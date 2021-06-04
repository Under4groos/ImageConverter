using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageConverter
{

    public class Converter
    {
        Image img = null;
        ImageFormat imgform = ImageFormat.Png;
        public Converter(string file)
        {
            if(File.Exists(file))
                img = Image.FromFile(file);
            
        }
        public Converter(Image image)
        {
            img = image;
        }

        public void SetFormat(string str)
        {
            switch (str)
            {
                case ".bmp":
                    imgform = ImageFormat.Bmp;
                    break;
                case ".gif":
                    imgform = ImageFormat.Gif;
                    break;
                case ".jpeg":
                    imgform = ImageFormat.Jpeg;
                    break;
                case ".jpg":
                    imgform = ImageFormat.Jpeg;
                    break;
                case ".png":
                    imgform = ImageFormat.Png;
                    break;
                case ".tiff":
                    imgform = ImageFormat.Tiff;
                    break;
                case ".ico":
                    imgform = ImageFormat.Icon;
                    break;
                default:
                    imgform = ImageFormat.Png;
                    break;

            }
        }


        public string GetSize()
        {
            return $"_{img.Width}x{img.Height}_";
        }
                public void Save(string save_name)
        {
            
            img.Save(save_name, imgform);
             
            img.Dispose();
        }
    }
}
