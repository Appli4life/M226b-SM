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

namespace Wochentag
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        readonly Wochentag g = new Wochentag(8, 2, 2003);
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            tag.Text = Convert.ToString(DateTime.Today.Day);
            monat.Text = Convert.ToString(DateTime.Today.Month);
            jahr.Text = Convert.ToString(DateTime.Today.Year);
        }

        /// <summary>
        /// Wochentag ausrechnen
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="Exception">Leere Felder</exception>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tag.Text == "" || monat.Text == "" || jahr.Text == "")
                {
                    throw new Exception("Datum Darf nicht leer sein!");
                }
              
                    Wochentag w = new Wochentag(Convert.ToInt32(tag.Text), Convert.ToInt32(monat.Text), Convert.ToInt32(jahr.Text));
                    wochentag.Content = w.GibWochenTag();

            }
            catch(Exception ex)
            {
                MessageBox.Show(messageBoxText: ex.Message, null, MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            tag.Text = Convert.ToString(g.T);
            monat.Text = Convert.ToString(g.M);
            jahr.Text = Convert.ToString(g.J);
        }


    }
}
