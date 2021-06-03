using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageConverter
{
    public static class imgFormats
    {
        public static List<string> formats = new List<string>()
            {
                ".bmp",
                ".gif",
                ".jpeg",
                ".jpg",
                ".png",
                ".tiff",
                ".ico"
            };

        public static bool isImageFormat(this string format_)
        {
            bool b = false;
            foreach (var item in formats)
                if (Path.GetExtension(format_).ToLower() == item.ToLower())
                {

                    b = true;
                    break;
                }           
            return b;
        }
    }
}
