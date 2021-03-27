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

namespace ColoresGIT
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnRed_Click(object sender, RoutedEventArgs e)
        {
            Red red = new Red();
            red.Show();
            this.Close();

        }

        private void btnAzul_Click(object sender, RoutedEventArgs e)
        {
            Blue blue = new Blue();
            blue.Show();
            this.Close();
        }

        private void btnVerde_Click(object sender, RoutedEventArgs e)
        {
            Green green = new Green();
            green.Show();
            this.Close();
        }

        private void btnAmarillo_Click(object sender, RoutedEventArgs e)
        {
            Yellow yellow = new Yellow();
            yellow.Show();
            this.Close();
        }
    }
}
