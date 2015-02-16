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
    /// Interaction logic for Splash.xaml
    /// </summary>
    public partial class Splash : Window
    {
        public Splash()
        {
            InitializeComponent();
        }



        private void move(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void load()
        {
            while (ProgressBar.Value < ProgressBar.Maximum)
            {
                ProgressBar.Value = .5;
                System.Threading.Thread.Sleep(50);
            }
        }

        private void Label_Initialized_1(object sender, EventArgs e)
        {
            load();
        }

        private void loginAluno(object sender, RoutedEventArgs e)
        {
            login telaLogin = new login();
            telaLogin.Show();
            this.Close();
        }

        private void AdmLabel_TouchUp(object sender, TouchEventArgs e)
        {
           
        }

        private void AdmCadUser(object sender, RoutedEventArgs e)
        {
            AdmCadUsuario telaAdm = new AdmCadUsuario();
            telaAdm.Show();
            this.Close();
        }











    }
}
