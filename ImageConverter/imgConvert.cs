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

    public class imgConvert
    {
        Image img = null;
        public imgConvert(string file)
        {
            if(File.Exists(file))
                img = Image.FromFile(file);
            
        }

        
        public ImageFormat ImgFormat(string str)
        {
            switch (str)
            {
                case ".bmp":
                    return ImageFormat.Bmp;
                case ".gif":
                    return ImageFormat.Gif;
                case ".jpeg":
                    return ImageFormat.Jpeg;
                case ".jpg":
                    return ImageFormat.Jpeg;
                case ".png":
                    return ImageFormat.Png;
                case ".tiff":
                    return ImageFormat.Tiff;
                case ".ico":
                    return ImageFormat.Icon;
                default:
                    return ImageFormat.Png;

            }
        }


        public string GetSize()
        {
            return $"_{img.Width}_{img.Height}_";
        }

        public void Save(string save_name , ImageFormat imgform)
        {
            
            img.Save(save_name, imgform);
            img.Dispose();
        }
    }
}
