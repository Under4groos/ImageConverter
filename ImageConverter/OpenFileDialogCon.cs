using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;

namespace ImageConverter
{
    public static class OpenFileDialogCon
    {
        public static bool OpenAndAddStackPanel(this StackPanel stackPanel)
        {
            bool b = false; UInt16 count = 0;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            // openFileDialog1.InitialDirectory = @"C:\";
            openFileDialog1.Filter = "All files (*.*)|*.*";
            openFileDialog1.Multiselect = true;
            openFileDialog1.ShowDialog();
            if(openFileDialog1.FileNames.Length <= 0)
                return false;
            foreach (String file in openFileDialog1.FileNames)
            {
                if(stackPanel.Children.Count >= 8)
                    break;
                if (file.isImageFormat())
                {
                    Label l = new Label()
                    {
                        FontSize = 14,
                        FontFamily = new FontFamily("Franklin Gothic Medium"),
                        Content = file
                    };
                    l.MouseDown += (o, e_) =>
                    {
                        SelectControl.ControlSelect = o as System.Windows.Controls.Label;
                    };
                    stackPanel.Children.Add(l);
                    count++; b = true;
                }  
            }
            return b;
        }
    }
}
