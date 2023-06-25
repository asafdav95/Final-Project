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
using System.Windows.Shapes;

namespace PDGUI
{
    /// <summary>
    /// Interaction logic for result.xaml
    /// </summary>
    public partial class result : Window
    {
        MainWindow mw;
        int windowID = 2;

        public result(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;


        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            mw.windowList[windowID + 1].Visibility = Visibility.Visible;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            mw.windowList[windowID - 1].Visibility = Visibility.Visible;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string imagePath = @"C:\Users\arnso\Documents\School\School\Semester 8\Final Project B\PDGUI\PDGUI\PDGUI\Content\plot.jpg";
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();
            bitmap.UriSource = new Uri(imagePath, UriKind.RelativeOrAbsolute);
            bitmap.EndInit();

            clusterImage.Source = bitmap;
        }
    }
}
