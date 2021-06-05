using ImageConverter.FormatsImage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;

namespace ImageConverter
{
    public static class SelectControl
    {
        public static UIElement ControlSelect = null;
    }
 

    public partial class MainWindow : Window
    {
        List<string> Files = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            WinResize winResize = new WinResize(this);
            UpDownPanel.Visibility = Visibility.Hidden;
            foreach (var item in Formats.formats)
            {
                System.Windows.Controls.Label l = new System.Windows.Controls.Label();
                l.Content = item;
                TestUD.add(l);
            }
        }

        private void Border_MouseDown(object sender, MouseButtonEventArgs e)
        {

            if (StackPanel.OpenAndAddStackPanel())
            {
                SelectFiles.Visibility = Visibility.Hidden;
                SelectedDD.Visibility = Visibility.Visible;

                if (StackPanel.Children.Count > 0)
                {
                    UpDownPanel.Visibility = Visibility.Visible;
                    LodingProggress.Content = $"Count: {0}/{StackPanel.Children.Count}";
                }
            }
        }

        private void Border_MouseDown_1(object sender, MouseButtonEventArgs e)
        {
            if (SelectFiles.Visibility == Visibility.Hidden)
            {
                SelectFiles.Visibility = Visibility.Visible;
                SelectedDD.Visibility = Visibility.Hidden;
            }
            else
            {
                SelectFiles.Visibility = Visibility.Hidden;
                SelectedDD.Visibility = Visibility.Visible;
            }
        }

        private void Border_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            
            try
            {
                if (StackPanel.Children.Count <= 0)
                    return;
                FolderBrowserDialog FolderDialog = new FolderBrowserDialog();

                DialogResult result = FolderDialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();
                    var t = FolderDialog.SelectedPath;
                    int count_f = 1;
                    foreach (UIElement item in StackPanel.Children)
                    {
                        string cur_file = (string)(item as System.Windows.Controls.Label).Content;
                        string filename = System.IO.Path.GetFileName(cur_file);
                        long fole_size = new System.IO.FileInfo(cur_file).Length;
                        if (!File.Exists(cur_file))
                            return;
                        if (System.IO.Path.GetExtension(cur_file).ToLower() == Formats.formats[1])
                        {
                            if (TestUD.GetTextContent().ToLower() == Formats.formats[1])
                            {
                                File.Copy(cur_file, t + $@"\ddd.gif");
                                continue;
                            }
                            GifToImages gifImage = new GifToImages(cur_file);
                            for (int i = 0; i < gifImage.FRAME_COUNT; i++)
                            {
                                string directory_conver_gif_imgs = t + $@"\{filename}_{fole_size}_{TestUD.GetTextContent().Replace(".", "_")}";
                                if (!Directory.Exists(directory_conver_gif_imgs))
                                    Directory.CreateDirectory(directory_conver_gif_imgs);
                                Converter imgConvert = new Converter(gifImage.GetFrame(i));
                                string dir_save = $@"{directory_conver_gif_imgs}\file_{i}_{imgConvert.GetSize()}{TestUD.GetTextContent()}";
                                imgConvert.SetFormat(TestUD.GetTextContent());
                                imgConvert.Save(
                                   dir_save
                                );
                                LodingProggress.Content = $"Gif frames: {i}/{gifImage.FRAME_COUNT - 1}";
                            }
                        }
                        else
                        {
                            Converter imgConvert = new Converter(cur_file);
                            string dir_save = t + $@"\{filename.Replace(".", "_")}{imgConvert.GetSize()}{TestUD.GetTextContent()}";
                            imgConvert.SetFormat(TestUD.GetTextContent());
                            imgConvert.Save(dir_save);
                            LodingProggress.Content = $"Count: {count_f}/{StackPanel.Children.Count}";
                        }
                        count_f++;
                    }
                    stopWatch.Stop();
                    TimeSpan ts = stopWatch.Elapsed;
                    RunTime.Content = String.Format("{0:00}:{1:00}:{2:00}.{3:00}", ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
                }
            
            }
            catch (Exception)
            {
                System.Windows.MessageBox.Show("Ошибка!\nОдин или несколько файлов не удалось открыть.");
            }
        }

        private void BorderCOnvertAddnew_MouseDown(object sender, MouseButtonEventArgs e)
        => StackPanel.OpenAndAddStackPanel();

        private void Border_MouseDown_3(object sender, MouseButtonEventArgs e)
        => this.Close();

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
                        l.MouseDown += (o, e_) =>
                        {
                            SelectControl.ControlSelect = o as System.Windows.Controls.Label;
                        };
                        StackPanel.Children.Add(l);

                    }
                }
                if (StackPanel.Children.Count > 0)
                {
                    SelectFiles.Visibility = Visibility.Hidden;
                    SelectedDD.Visibility = Visibility.Visible;
                    UpDownPanel.Visibility = Visibility.Visible;

                    LodingProggress.Content = $"Count: {0}/{StackPanel.Children.Count}";
                }

            }
        }

        private void BorderCOnvertClear_MouseDown(object sender, MouseButtonEventArgs e)
        {
            StackPanel.Children.Clear();
            SelectFiles.Visibility = Visibility.Visible;
            SelectedDD.Visibility = Visibility.Hidden;
            UpDownPanel.Visibility = Visibility.Hidden;
            RunTime.Content = " - ";
        }

        private void Border_MouseDown_4(object sender, MouseButtonEventArgs e)
        {
            switch (this.WindowState)
            {
                case WindowState.Normal:
                    this.WindowState = WindowState.Minimized;
                    break;
                case WindowState.Minimized:
                    this.WindowState = WindowState.Normal;
                    break;
                case WindowState.Maximized:
                    this.WindowState = WindowState.Normal;
                    break;
                default:
                    this.WindowState = WindowState.Normal;
                    break;
            }
        }

        private void BorderCOnvertClearAT_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (SelectControl.ControlSelect == null)
                return;
            StackPanel.Children.Remove(SelectControl.ControlSelect);
            LodingProggress.Content = $"Count: {0}/{StackPanel.Children.Count}";
        }

        private void Label_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if( e.LeftButton == MouseButtonState.Pressed)
            {
                Process.Start("https://github.com/Under4groos/ImageConverter");
            }
            
        }
    }
}
