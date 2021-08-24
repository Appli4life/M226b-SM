using System;
using CircleLibrary;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Exceptions.Cirvle;

namespace Exceptions.Circle
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

        private void circle_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CircleLibrary.Circle c = new CircleLibrary.Circle(-10, 2, 3);
            }
            catch (CircleException ce)
            {
                MessageBox.Show($"Fehlernummer: {ce.CircleErrorNum}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void konver_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int zahl1 = Convert.ToInt32("my bad");
            }
            catch (FormatException ke)
            {
                MessageBox.Show($"Formatfehler: {ke.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (OverflowException over)
            {
                MessageBox.Show($"Overflowfehler: {over.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void mehr_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenTextdatei();
            }
            catch (DirectoryNotFoundException de)
            {
                MessageBox.Show($"Fehler: {de.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (FileNotFoundException fe)
            {
                MessageBox.Show($"Fehler: {fe.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (ArgumentException ae)
            {
                MessageBox.Show($"Fehler: {ae.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            catch (Exception)
            {
                MessageBox.Show("Fehler!");
            }
        }

        private void mit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OpenTextdatei();
            }
            catch (Exception ec)
            {
                MessageBox.Show($"Fehler: {ec.Message}", "Fehler", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void ohne_Click(object sender, RoutedEventArgs e)
        {
            OpenTextdatei();
        }

        public void OpenTextdatei()
        {
            StreamReader stream = new StreamReader(@"C:\Temp\Test.txt");
            MessageBox.Show(stream.ReadToEnd());
            stream.Close();
        }
    }
}
