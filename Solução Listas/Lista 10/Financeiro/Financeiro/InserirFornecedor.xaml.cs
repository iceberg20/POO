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

namespace Financeiro
{
    /// <summary>
    /// Interaction logic for InserirFornecedor.xaml
    /// </summary>
    public partial class InserirFornecedor : Window
    {
        private Fornecedores f;
        public InserirFornecedor()
        {
            InitializeComponent();
        }

        public Fornecedores F { set { f = value; } }

        private void AddFornecedor(object sender, RoutedEventArgs e)
        {
            Fornecedor novo = new Fornecedor();
            novo.id = int.Parse(FTB1.Text);
            novo.nome = FTB2.Text;
      
            f.Add(novo);
            DialogResult = true;
            this.Close();
        }
    }
}
