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

namespace Agenda
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Ag ga = new Ag();
      //  Horario h = new Horario();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ShowWindowAddCompromisso(object sender, RoutedEventArgs e)
        {
            NovoCompromisso novo = new NovoCompromisso();
            novo.g = Agenda();
            if(novo.ShowDialog()==true)  
                Listar(sender,e);
        }

        public Ag Agenda() 
        {
            return ga;
        }

        private void Listar(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();
            foreach (Object o in ga)
            {
                ListBox1.Items.Add(o.ToString());
            }
        }

        private void Salvar(object sender, RoutedEventArgs e)
        {
            Persistencia<Ag> arq =
                new Persistencia<Ag>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\financeiro.xml";
            arq.SalvarArquivo(path, ga);
        }

        private void Abrir(object sender, RoutedEventArgs e)
        {
            Persistencia<Ag> arq =
                  new Persistencia<Ag>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\agenda.xml";
            ga = arq.AbrirArquivo(path);

            Listar(sender, e);
        }

        private void ListShow(object sender, SelectionChangedEventArgs e)
        {
            if (ListBox1.SelectedIndex >= 0)
            {
                TBM1.Text = ga[ListBox1.SelectedIndex].assunto;
                TBM2.Text = ga[ListBox1.SelectedIndex].local;
                TBM3.Text = ga[ListBox1.SelectedIndex].horario.ToString();
            }
        }

    }
}
