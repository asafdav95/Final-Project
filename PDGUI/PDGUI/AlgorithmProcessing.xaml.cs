using System;
using System.Collections.Generic;
using System.Diagnostics;
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
    /// Interaction logic for AlgorithmProcessing.xaml
    /// </summary>
    public partial class AlgorithmProcessing : Window
    {
        MainWindow mw;
        int windowID = 1;
        Random rand = new Random();
        public AlgorithmProcessing(MainWindow mw)
        {
            InitializeComponent();
            this.mw = mw;

            stage_preProc.Visibility = Visibility.Hidden;
            stage_token.Visibility = Visibility.Hidden;
            stage_embed.Visibility = Visibility.Hidden;
            stage_RCNNA.Visibility = Visibility.Hidden;
            stage_DTW.Visibility = Visibility.Hidden;
            stage_Isolated.Visibility = Visibility.Hidden;

            arrow1.Visibility = Visibility.Hidden;
            arrow2.Visibility = Visibility.Hidden;
            arrow3.Visibility = Visibility.Hidden;
            arrow4.Visibility = Visibility.Hidden;
            arrow5.Visibility = Visibility.Hidden;

            Next.Visibility = Visibility.Hidden;


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



        private async Task Run_ClickedAsync()
        {
            stage_preProc.Visibility = Visibility.Visible;
            arrow1.Visibility = Visibility.Visible;
            Run.Content = "Running";
            progress.Value += rand.Next(15, 19);
            await Task.Delay(2200);

            stage_token.Visibility = Visibility.Visible;
            arrow2.Visibility = Visibility.Visible;
            Run.Content = "Running.";
            progress.Value += rand.Next(2, 7);
            await Task.Delay(800);

            stage_embed.Visibility = Visibility.Visible;
            arrow3.Visibility = Visibility.Visible;
            Run.Content = "Running..";
            progress.Value += rand.Next(20, 25);
            await Task.Delay(12800);

            stage_RCNNA.Visibility = Visibility.Visible;
            arrow4.Visibility = Visibility.Visible;
            Run.Content = "Running...";
            progress.Value += rand.Next(20, 25);
            await Task.Delay(10600);

            stage_DTW.Visibility = Visibility.Visible;
            arrow5.Visibility = Visibility.Visible;
            Run.Content = "Running.";
            progress.Value += rand.Next(5, 10);
            await Task.Delay(4000);

            stage_Isolated.Visibility = Visibility.Visible;

            Next.Visibility = Visibility.Visible;
            progress.Value = 100;
            Run.Content = "Completed";
        }

        private void Run_ClickedAsync(object sender, RoutedEventArgs e)
        {
            Run.Content = "Running...";
            progress.Value += rand.Next(5,10);
            Run_ClickedAsync();
            Run_PythonClustering();
            
        }

        private void Run_PythonClustering()
        {
            string pythonScript = @"C:\Users\arnso\Documents\School\School\Semester 8\Final Project B\PDGUI\PDGUI\PDGUI\Content\clustering.py"; // Replace with the path to your Python script

            try
            {
                ProcessStartInfo start = new ProcessStartInfo();
                start.FileName = "python"; // Assuming "python" is in your system's PATH environment variable
                start.Arguments = pythonScript;
                start.UseShellExecute = false;
                start.RedirectStandardOutput = true;

                using (Process process = Process.Start(start))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        Console.WriteLine(result);
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("An error occurred while running the Python script: " + e.Message);
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Run.Content = "Run";
            progress.Value = 0;
            Next.Visibility = Visibility.Hidden;
        }
    }
}
