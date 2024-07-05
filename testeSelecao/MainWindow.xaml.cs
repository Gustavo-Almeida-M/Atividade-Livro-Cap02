using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace testeSelecao
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

        private void radio01_Checked(object sender, RoutedEventArgs e)
        {
            blocoEscrita.Text = "1";
        }

        private void radio02_Checked(object sender, RoutedEventArgs e)
        {
            blocoEscrita.Text = "2";
        }
        private void radio03_Checked(object sender, RoutedEventArgs e)
        {
            blocoEscrita.Text = "3";
        }
        private void radio04_Checked(object sender, RoutedEventArgs e)
        {
            blocoEscrita.Text = "4";
        }

        private void radio05_Checked(object sender, RoutedEventArgs e)
        {
            blocoEscrita.Text = "5";
        }

        private void radio06_Checked(object sender, RoutedEventArgs e)
        {
            blocoEscrita.Text = "6";
        }

        private void inputTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            blocoEscrita.Text = inputTextBox.Text;
        }
    }
}