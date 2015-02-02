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

namespace Fibonacci
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Fib f = new Fib();

        public MainWindow()
        {
            InitializeComponent();

        }

        private void ButtonRest(object sender, RoutedEventArgs e)
        {
            f.Reiniciar();
        }

        private void ButtonNext(object sender, RoutedEventArgs e)
        {
            TextBox1.Text += f.Proximo().ToString() + System.Environment.NewLine;
        }
    }
}
