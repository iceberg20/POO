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

namespace SistemaAcademico
{
    /// <summary>
    /// Interaction logic for AdmCadUsuario.xaml
    /// </summary>
    public partial class AdmCadUsuario : Window
    {
        public AdmCadUsuario()
        {
            InitializeComponent();
        }

        private void CadastrarUsuario(object sender, RoutedEventArgs e)
        {
            Usuario u = new Usuario();
            u.tipo = ComboBox1.SelectionBoxItem.ToString();
            u.login = AdmTB1.Text;
            u.senha = AdmTB2.Text;

            ser


        }
    }
}
