using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageConverter
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> Files = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            WinResize winResize = new WinResize(this);



            foreach (var item in imgFormats.formats)
            {
                System.Windows.Controls.Label l = new System.Windows.Controls.Label();
                l.Content = item;
                TestUD.add(l);
            }
                
             
        }

    
        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if( StackPanel.OpenAndAddStackPanel())
            {
                SelectFiles.Visibility = Visibility.Hidden;
                SelectedDD.Visibility = Visibility.Visible;
            }  
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            StackPanel.Children.Clear();
            SelectFiles.Visibility = Visibility.Visible;
            SelectedDD.Visibility = Visibility.Hidden;
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            if (StackPanel.Children.Count <= 0)
                return;
            FolderBrowserDialog FolderDialog = new FolderBrowserDialog();
          
            DialogResult result = FolderDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                var t = FolderDialog.SelectedPath;
                foreach (UIElement item in StackPanel.Children)
                {
                    string cur_file = (string)(item as System.Windows.Controls.Label).Content;
                    imgConvert imgConvert = new imgConvert(cur_file);
                    long length = new System.IO.FileInfo(cur_file).Length;
                    imgConvert.Save(t + $@"\{length}{imgConvert.GetSize()}{TestUD.GetTextContent()}", imgConvert.ImgFormat(TestUD.GetTextContent()));
                }
            }
        }

        private void BorderCOnvertAddnew_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel.OpenAndAddStackPanel();
        }

        private void Border_MouseDown_3(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        private void Window_Drop(object sender, System.Windows.DragEventArgs e)
        {
            if (e.Data.GetDataPresent(System.Windows.DataFormats.FileDrop))
            {
                string[] files = (string[])e.Data.GetData(System.Windows.DataFormats.FileDrop);
                foreach (string file in files)
                {
                    if (StackPanel.Children.Count >= 8)
                    {
                        break;
                    }
                    if (file.isImageFormat())
                    {
                        System.Windows.Controls.Label l = new System.Windows.Controls.Label()
                        {
                            FontSize = 14,
                            FontFamily = new FontFamily("Franklin Gothic Medium"),
                            Content = file
                        };
                        StackPanel.Children.Add(l);
                         
                    }
                }
                if (StackPanel.Children.Count > 0)
                {
                    SelectFiles.Visibility = Visibility.Hidden;
                    SelectedDD.Visibility = Visibility.Visible;
                }
                
            }
        }
    }
}
