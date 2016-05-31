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
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class WindowRemoveAPlayer : Window
    {

        public MainWindow WindowsPrincipal;
        public FootballPlayer playerSelected;

        public WindowRemoveAPlayer(MainWindow windowPrincipal, FootballPlayer ps)
        {
            WindowsPrincipal = windowPrincipal;
            InitializeComponent();
            playerSelected = ps;
      
        }


        private void YesButton(object sender, RoutedEventArgs e)
        {

            WindowsPrincipal.FrenchTeam.RemovePlayer(playerSelected.Name, playerSelected.FirstName);
            Close();

        }

        private void NoButton(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
