using Microsoft.Win32;
using PDGUI;
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
using System.IO;
using System.Windows.Forms;
using OpenFileDialog = Microsoft.Win32.OpenFileDialog;

namespace PDGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Window[] windowList = new Window[4];
        int windowID = 0;

        public MainWindow()
        {
            InitializeComponent();

            windowList[0] = this;
            windowList[1] = new AlgorithmProcessing(this);
            windowList[2] = new result(this);
            windowList[3] = new listResult(this);
            
            epochComboBox.SelectedIndex = 0;

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Collapsed;
            windowList[windowID + 1].Visibility = Visibility.Visible;
        }

        private void browseImposterSetBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string selectedFolderPath = dialog.SelectedPath;
                    impTxtFld.Text = selectedFolderPath;
                }
            }
        }

        private void browseTestCollectionBtn_Click(object sender, RoutedEventArgs e)
        {
            using (var dialog = new FolderBrowserDialog())
            {
                DialogResult result = dialog.ShowDialog();
                if (result == System.Windows.Forms.DialogResult.OK)
                {
                    string selectedFolderPath = dialog.SelectedPath;
                    testColTxtFld.Text = selectedFolderPath;
                }
            }
        }
    }
}