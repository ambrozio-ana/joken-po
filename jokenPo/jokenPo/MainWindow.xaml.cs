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

namespace jokenPo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random r = new Random();
        int jogadaC = 0;
        int jogadaV = 0;
        int contagemVitoriaV = 0;
        int contagemVitoriaC = 0;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void EscolherPapel(object sender, RoutedEventArgs e)
        {
            imgPedraV.Visibility = Visibility.Hidden;
            imgTesouraV.Visibility = Visibility.Hidden;
            imgPapelV.Visibility = Visibility.Visible;
            jogadaV = 2;
            ComputadorJoga();
            Ganhador();
        }

        private void EscolherPedra(object sender, RoutedEventArgs e)
        {
            imgPapelV.Visibility = Visibility.Hidden;
            imgTesouraV.Visibility = Visibility.Hidden;
            imgPedraV.Visibility = Visibility.Visible;
            jogadaV = 1;
            ComputadorJoga();
            Ganhador();
        }

        private void EscolherTesoura(object sender, RoutedEventArgs e)
        {
            imgPedraV.Visibility = Visibility.Hidden;
            imgPapelV.Visibility = Visibility.Hidden;
            imgTesouraV.Visibility = Visibility.Visible;
            jogadaV = 0;
            ComputadorJoga();
            Ganhador();
        }

        private void ComputadorJoga()
        {
            int rComputador = r.Next(0, 3);
            jogadaC = rComputador;

            if (rComputador == 0)
            {
                imgPedraC.Visibility = Visibility.Hidden;
                imgPapelC.Visibility = Visibility.Hidden;
                imgTesouraC.Visibility = Visibility.Visible;
            }
            else if (rComputador == 1)
            {
                imgPapelC.Visibility = Visibility.Hidden;
                imgTesouraC.Visibility = Visibility.Hidden;
                imgPedraC.Visibility = Visibility.Visible;
            }
            else if (rComputador == 2)
            {
                imgPedraC.Visibility = Visibility.Hidden;
                imgTesouraC.Visibility = Visibility.Hidden;
                imgPapelC.Visibility = Visibility.Visible;
            }
        }

        private void Ganhador()
        {
            // Lógica para empate
            if (jogadaC == 0 && jogadaV == 0)
            {
                txtJogadorVencedor.Text = "Empate!";
            }
            else if (jogadaC == 1 && jogadaV == 1)
            {
                txtJogadorVencedor.Text = "Empate!";
            }
            else if (jogadaC == 2 && jogadaV == 2)
            {
                txtJogadorVencedor.Text = "Empate!";
            }

            // Lógica para computador ganhar
            if (jogadaC == 0 && jogadaV == 2)
            {
                txtJogadorVencedor.Text = "Computador ganhou!";
                contagemVitoriaC++;
            }
            else if (jogadaC == 2 && jogadaV == 1)
            {
                txtJogadorVencedor.Text = "Computador ganhou!";
                contagemVitoriaC++;
            }
            else if (jogadaC == 1 && jogadaV == 0)
            {
                txtJogadorVencedor.Text = "Computador ganhou!";
                contagemVitoriaC++;
            }

            // Lógica para você ganhar
            if (jogadaC == 2 && jogadaV == 0)
            {
                txtJogadorVencedor.Text = "Você ganhou!";
                contagemVitoriaV++;
            }
            else if (jogadaC == 1 && jogadaV == 2)
            {
                txtJogadorVencedor.Text = "Você ganhou!";
                contagemVitoriaV++;
            }
            else if (jogadaC == 0 && jogadaV == 1)
            {
                txtJogadorVencedor.Text = "Você ganhou!";
                contagemVitoriaV++;
            }

            txtComputadorVit.Text = contagemVitoriaC.ToString();
            txtVoceVit.Text = contagemVitoriaV.ToString();
        }

    }
}
