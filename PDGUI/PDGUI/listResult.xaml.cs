using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for listResult.xaml
    /// </summary>
    public partial class listResult : Window
    {
        MainWindow mw;
        int windowID = 3;

        public listResult(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            mw.windowList[windowID - 1].Visibility = Visibility.Visible;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string cluster1Path = @"C:\Users\arnso\Documents\School\School\Semester 8\Final Project B\PDGUI\PDGUI\PDGUI\Content\cluster1.txt"; // Replace with the path to your text file
            string cluster2Path = @"C:\Users\arnso\Documents\School\School\Semester 8\Final Project B\PDGUI\PDGUI\PDGUI\Content\cluster2.txt"; // Replace with the path to your text file

            cluster1TxtBlock.Text = "";
            cluster2TxtBlock.Text = "";

            try
            {
                using (StreamReader sr = new StreamReader(cluster1Path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cluster1TxtBlock.Text += line + "\n";
                    }
                }

                using (StreamReader sr = new StreamReader(cluster2Path))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        cluster2TxtBlock.Text += line + "\n";
                    }
                }
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while reading the file: " + ex.Message);
            }
        }
    }
}
