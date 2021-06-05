using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ImageConverter.UiControls
{
    /// <summary>
    /// Логика взаимодействия для ComboBox.xaml
    /// </summary>
    public partial class ComboBox : UserControl
    {
        bool isOpen = false;
        public ComboBox()
        {
            InitializeComponent();   
        }
        public string GetTextContent() => CurText.Content as string;


        public void add(Label l) 
        {
            l.HorizontalContentAlignment = HorizontalAlignment.Center;
            l.VerticalContentAlignment = VerticalAlignment.Center;
            l.Foreground = new SolidColorBrush(Color.FromRgb(255,255,255));
            l.Padding = new Thickness(0);
            l.FontSize = 16;         
            l.MouseDown += (o, e) => CurText.Content = (o as Label).Content;
            ListLabel.Children.Add(l);
            CurText.Content = l.Content; 
        }

        private void CurText_MouseDown(object sender, MouseButtonEventArgs e)
        {
            isOpen = !isOpen;
            OC(isOpen);
        }
        public void OC(bool i)
        {
            switch (i)
            {
                case true:
                    this.Height = CurText.ActualHeight + ListLabel.ActualHeight;
                    break;
                case false:
                    this.Height = CurText.ActualHeight;
                    break;
                default:
                    break;
            }       
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        => OC(isOpen);
    }
}
