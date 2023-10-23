using Microsoft.Win32;
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
using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_WORDPADD
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtchange(object sender, TextChangedEventArgs e)
        {

        }

        private void open_MouseEnter(object sender, MouseEventArgs e)
        {

        }

        private void openclick(object sender, RoutedEventArgs e)
        {
            Microsoft.Win32.OpenFileDialog open = new Microsoft.Win32.OpenFileDialog();
            open.InitialDirectory = "C:\\Users\\ROG\\source\\repos\\WPF_WORDPADD\\WPF_WORDPADD";

            bool? result = open.ShowDialog();

            if (result == true)
            {
                string filePath = open.FileName;
                string fileContent = File.ReadAllText(filePath);

                
                usertext.AppendText(fileContent);
            }
        }

        private void change(object sender, TextChangedEventArgs e)
        {

        }
    }
}
