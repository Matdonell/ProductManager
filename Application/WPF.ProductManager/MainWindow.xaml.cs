using CoupeDuMondeFootball;
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

namespace WPF.ProductManager
{
    public partial class MainWindow : Window
    {

        // Reference to a FootballTeam for acess to the static list
        public FootballTeam FrenchTeam
        {
            get;
            set;
        }

        // Builer main window
        public MainWindow()
        {
            FrenchTeam = new FootballTeam();
            InitializeComponent();
            InitializePlayer();
        }


        private void InitializePlayer()
        {
            mListeBox_Player.Items.Clear();

            // Order by Name
            var players = FootballTeam.ListFootballPlayer.OrderBy(s => s.Name);
            // Add all football player to List box
            foreach (var player in players)
            {
                mListeBox_Player.Items.Add(player);
            }
            mListeBox_Player.SelectedIndex = 0;
        }

        // Refresh the football player list box
        public void UpdateListPlayer()
        {
            mListeBox_Player.Items.Refresh();
        }


        private void mListeBox_Player_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (e.AddedItems.Count < 1) return;
            //Get the selected player
            FootballPlayer playerSelected = e.AddedItems[0] as FootballPlayer;

            if (playerSelected == null) return;


            // Replace current informations
            Name.Text = playerSelected.Name;
            FirstName.Text = playerSelected.FirstName;
            Birthdate.Text = playerSelected.BirthDate.ToString();
            Number.Text = playerSelected.playerPosition.Number.ToString();
            Position.Text = playerSelected.playerPosition.Position.ToString();
            Uri Picture = new Uri("Image/" + playerSelected.Picture.ToString().ToLower() + ".png", UriKind.Relative);
            mPicture.Source = new BitmapImage(Picture);

            // With Data Binding
            mListeBox_Club2.DataContext = playerSelected;

            // Without Data Binding
            //mListeBox_Club.Items.Clear();
            //foreach (var club in playerSelected.ListClub)
            //{
            //    mListeBox_Club.Items.Add(club);
            //}

        }

   
        // When one text Box of the selected player is changed
        private void mTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var playerSelected = mListeBox_Player.SelectedItem as FootballPlayer;
            if (playerSelected == null)
            {
                return;
            }

            TextBox textBox = sender as TextBox;
            if (textBox == null) return;

            switch (textBox.Name)
            {
                case "Name":
                    playerSelected.Name = textBox.Text;
                    break;

                case "FirstName":
                    playerSelected.FirstName = textBox.Text;
                    break;

                case "BirthDate":
                    playerSelected.BirthDate = DateTime.Parse(textBox.Text);
                    break;

                case "Number":
                    try
                    {
                        playerSelected.playerPosition.Number = int.Parse(textBox.Text);

                    }
                    catch (FormatException exc)
                    {
                        break;
                    }
                    break;
            }
            UpdateListPlayer();
        }


        // method to add a new player
        private void WeAddAPlayer(object sender, RoutedEventArgs e)
        {
            // We creat a new window 
            var windowAddPlayer = new WindowAddPlayer(this);

            // Block the main Window when the windoww player is open
            windowAddPlayer.ShowDialog();

            // We refresh data in main Window
            UpdateListPlayer();
            InitializePlayer();
        }

        private void WeRemoveAPlayer(object sender, RoutedEventArgs e)
        {
            var playerSelected = mListeBox_Player.SelectedItem as FootballPlayer;
            if (playerSelected == null)
            {
                return;
            }

            var windowRemoveAPlayer = new WindowRemoveAPlayer(this, playerSelected);
            windowRemoveAPlayer.ShowDialog();
            UpdateListPlayer();
            InitializePlayer();
        }

        private void WeAddAClub(object sender, RoutedEventArgs e)
        {
            var playerSelected = mListeBox_Player.SelectedItem as FootballPlayer;
            if (playerSelected == null)
            {
                return;
            }

            var windowAddAClub = new WindowAddAClub(playerSelected);
            windowAddAClub.ShowDialog();
            UpdateListPlayer();
            InitializePlayer();
        }


        private void OnImageClicked(object sender, MouseButtonEventArgs e)
        {
            var playerSelected = mListeBox_Player.SelectedItem as FootballPlayer;
            if (playerSelected == null)
            {
                return;
            }

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            dlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            dlg.FileName = "Image"; // Default file name
            dlg.DefaultExt = ".jpg | .png | .gif"; // Default file extension
            dlg.Filter = "All images files (.png)|*.png;|PNG files (.png)|*.png"; // Filter files by extension 

            bool? result = dlg.ShowDialog();

            // Process open file dialog box results 
            if (result == true)
            {
                // Open document 
                string filename = dlg.FileName;


                System.IO.File.Copy(filename, string.Format("{0}/Images/{1}", System.IO.Directory.GetCurrentDirectory(), System.IO.Path.GetFileName(filename)), true);
 
                playerSelected.Picture = filename;
            }
        }

    }
}
