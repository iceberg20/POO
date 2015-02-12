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
            ListBox1.Items.Clear();
            foreach (Fornecedor obj in lista)
            {
                ListBox1.Items.Add(obj.id.ToString()+" - "+obj.nome); 
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
            string fn ="";  
            if(ComboBox1.SelectedItem.ToString() != null)
                fn = ComboBox1.SelectedItem.ToString();
            dp.idFornecedor = f.Find(x => x.nome == fn).id;
            dp.valor = double.Parse(TBM3.Text);
            d.Add(dp);

            ListBox1.Items.Clear();
            foreach (Despesa obj in d)
            {
                fn = f.Find(x => x.id == obj.idFornecedor).nome;
                string saida = obj.id.ToString() +" - "+ fn +" - "+ obj.data.ToShortDateString() +" - R$ "+ obj.valor.ToString();
               ListBox1.Items.Add(saida);
            }

        }

        private void Salvar(object sender, RoutedEventArgs e)
        {            
            Persistencia<Fornecedores> arq =
            new Persistencia<Fornecedores>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\financeiro_forncedor.xml";
            arq.SalvarArquivo(path, f);

            Persistencia<Despesas> arq2 =
            new Persistencia<Despesas>();
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\financeiro_despesa.xml";
            arq2.SalvarArquivo(path2, d);
        }

        private void Abrir(object sender, RoutedEventArgs e)
        {
            ListBox1.Items.Clear();

            Persistencia<Fornecedores> arq =
            new Persistencia<Fornecedores>();
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\financeiro_forncedor.xml";
            f = arq.AbrirArquivo(path);

            Persistencia<Despesas> arq2 =
            new Persistencia<Despesas>();
            string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\financeiro_despesa.xml";
            d = arq2.AbrirArquivo(path2);

            string saida="";
            
            foreach (Fornecedor obj in f)
            {
                ComboBox1.Items.Add(obj.nome);
            }

            foreach (Despesa obj in d)
            {
                int idf = obj.idFornecedor;
                string nf = f.Find(x => x.id == idf).nome;
                saida = obj.id.ToString() + " - " + nf + " - " + obj.data.ToShortDateString() + " - " + obj.valor.ToString();
                ListBox1.Items.Add(saida);
            }

            
        }



       
    }
}
