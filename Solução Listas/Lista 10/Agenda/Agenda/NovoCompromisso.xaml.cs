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
using System.Windows.Shapes;

namespace Agenda
{
    /// <summary>
    /// Interaction logic for NovoCompromisso.xaml
    /// </summary>
    public partial class NovoCompromisso : Window
    {
        public NovoCompromisso()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string assunto = TBC1.Text;
            string loc = TBC2.Text;
            int dia = int.Parse(TBC3.Text);
            int mes = int.Parse(TBC4.Text);
            int ano = int.Parse(TBC5.Text);
            int hora = int.Parse(TBC6.Text);
            int minuto = int.Parse(TBC7.Text);

            Horario h = new Horario(dia, mes, ano, hora, minuto);


            Compromisso c = new Compromisso(assunto,loc,h);
            Ag gg = new Ag();
            gg.Add(c);           
        }
    }
}
