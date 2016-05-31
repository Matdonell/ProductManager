using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoupeDuMondeFootball
{
    public class FootballPlayer
    {
        public String Name { get;  set; }

        public String FirstName { get; set; }

        public DateTime BirthDate { get; set; }

        public String Picture { get; set; }

        private List<Club> mListClub = new List<Club>();

        public PlayerPosition playerPosition;

     
        public List<Club> ListClub
        {
            get
            {
                return mListClub;
            }
        }

        public FootballPlayer(String name, String firstName, DateTime birthDate, String picture, Club[] club, PlayerPosition playerPosition )
        {
            Name = name;
            FirstName = firstName;
            BirthDate = birthDate;
            Picture = picture;
            ListClub.AddRange(club);
            this.playerPosition = playerPosition;            
        }


        public override string ToString()
        {
            return string.Format("{0} {1}", Name.ToUpper(), FirstName);
        }

        // Ajouter un club a la liste
        public void AddClub(String name, String country)
        {
            ListClub.Add(new Club(name, country));
        }

        public void ChangePlayerPosition(PlayerPosition playerPosition)
        {
            this.playerPosition = playerPosition;
        }

        // Suprimer un club à la liste
        public void RemoveClub(Club club)
        {
            ListClub.Remove(club);
        }





    }
}
