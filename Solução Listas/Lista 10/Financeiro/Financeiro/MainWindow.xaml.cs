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

namespace Financeiro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Fornecedores f;
        Despesas d;

        public MainWindow()
        {
            InitializeComponent();
            f = new Fornecedores();
            d = new Despesas();
        }

        public void Listar(Fornecedores lista)
        {
            foreach (Fornecedor obj in lista)
            {
                ListBox1.Items.Add(obj); 
            }
        }
        private void AddFornecedor(object sender, RoutedEventArgs e)
        {
            InserirFornecedor addFornecedor = new InserirFornecedor();
            addFornecedor.F = f;
            ComboBox1.Items.Clear();
            if (addFornecedor.ShowDialog() == true) 
            {
                foreach (Fornecedor obj in f)
                {
                    ComboBox1.Items.Add(obj.ToString());
                }
            }
        }

        private void InserirDespesa(object sender, RoutedEventArgs e)
        {
            Despesa dp = new Despesa();
            dp.id = int.Parse(TBM1.Text);
            string fn;  
            if(ComboBox1.SelectedItem.ToString() != null)
                fn = ComboBox1.SelectedItem.ToString();
           // int id = f.Find()

            ListBox1.Items.Add("aew");
         //   foreach (Despesa obj in d)
          //  {
               // ListBox1.Items.Add(obj.ToString());
          //  }

        }



       
    }
}
