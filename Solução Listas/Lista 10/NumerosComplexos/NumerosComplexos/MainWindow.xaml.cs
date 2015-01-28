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

namespace NumerosComplexos
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public double xr;
        public double xi;
        public double yr;
        public double yi;
        Complexo c1;
        Complexo c2;

        public MainWindow()
        {
            InitializeComponent();
            Complexo c1 = new Complexo();
            Complexo c2 = new Complexo();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            xr = Double.Parse(TBXReal.Text);
            xi = Double.Parse(TBXImag.Text);
            c1 = new Complexo(xr, xi);

            yr = Double.Parse(TBYReal.Text);
            yi = Double.Parse(TBYImag.Text);
            c2 = new Complexo(yr, yi);
            TBResultado.Text = (c1 + c2).ToString();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            xr = Double.Parse(TBXReal.Text);
            xi = Double.Parse(TBXImag.Text);
            c1 = new Complexo(xr, xi);

            yr = Double.Parse(TBYReal.Text);
            yi = Double.Parse(TBYImag.Text);
            c2 = new Complexo(yr, yi);
            TBResultado.Text = (c1 - c2).ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            xr = Double.Parse(TBXReal.Text);
            xi = Double.Parse(TBXImag.Text);
            c1 = new Complexo(xr, xi);

            yr = Double.Parse(TBYReal.Text);
            yi = Double.Parse(TBYImag.Text);
            c2 = new Complexo(yr, yi);
            TBResultado.Text = (c1 * c2).ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            xr = Double.Parse(TBXReal.Text);
            xi = Double.Parse(TBXImag.Text);
            c1 = new Complexo(xr, xi);

            yr = Double.Parse(TBYReal.Text);
            yi = Double.Parse(TBYImag.Text);
            c2 = new Complexo(yr, yi);
            TBResultado.Text = (c1 / c2).ToString();
        }
    }
}
