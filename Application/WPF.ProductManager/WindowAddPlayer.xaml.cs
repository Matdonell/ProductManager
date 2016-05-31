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
    /// Logique d'interaction pour WindowAddPlayer.xaml
    /// </summary>
    public partial class WindowAddPlayer : Window
    {
        public MainWindow WindowsPrincipal
        {
            get;
            set;
        }  
                                  

        public WindowAddPlayer(MainWindow windowPrincipal)
        {
            WindowsPrincipal = windowPrincipal;
            InitializeComponent();
            InitComboBoxTypes();
        }

        private void InitComboBoxTypes()
        {

            mComboBoxType.Items.Clear();

            foreach (var type in Enum.GetNames(typeof(PositionType)))
            {
                mComboBoxType.Items.Add(type);
            }
            mComboBoxType.SelectedIndex = 0;
        }

        private void ButtonAjouter(object sender, RoutedEventArgs e)
        {

            String nom = Nom.Text;
            String prenom = Prenom.Text;

            int num = Int32.Parse(Numero.Text);
            int year = Int32.Parse(Year.Text);
            int month = Int32.Parse(Month.Text);
            int day = Int32.Parse(Day.Text);
         
            string type = mComboBoxType.SelectedItem as string;
            var typeEnum = (PositionType)Enum.Parse(typeof(PositionType), type);

            WindowsPrincipal.FrenchTeam.AddPlayer(nom, prenom, new DateTime(year, month, day), num, typeEnum);
            

            
            Close();

        }

        private void ButtonAnnuler(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }


}
