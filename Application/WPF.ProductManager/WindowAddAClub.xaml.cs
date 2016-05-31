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
using CoupeDuMondeFootball;

namespace WPF.ProductManager
{
    /// <summary>
    /// Logique d'interaction pour WindowAddAClub.xaml
    /// </summary>
    public partial class WindowAddAClub : Window
    {
        public FootballPlayer playerSelected;

        public WindowAddAClub(FootballPlayer playerSelected)
        {
            InitializeComponent();
            this.playerSelected=playerSelected;
        }

        private void Valider(object sender, RoutedEventArgs e)
        {

            String pays = Pays.Text;
            String club = ClubName.Text;
            playerSelected.AddClub(pays, club);
            Close();

        }

        private void Annuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
