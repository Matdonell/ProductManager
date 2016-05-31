using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupeDuMondeFootball
{
    public class FootballTeam
    {
        // Afficher une liste de joueur ( pour Test )
        public void Display()
        {
            foreach (FootballPlayer player in ListFootballPlayer)
                Console.WriteLine(player);
            Console.WriteLine();
        }


        // Ajouter un joueur à la liste
        public void AddPlayer(String name, String firstName, DateTime birthTime, int number, PositionType position)
        {

            ListFootballPlayer.Add(new FootballPlayer(name, firstName, birthTime,
                "default", new Club[] { }, new PlayerPosition(number, position)));

        }

        // Suprimer un joueur de la liste
        public void RemovePlayer(String name, String firstName)
        {
            List<FootballPlayer> playerToRemove = ListFootballPlayer.Where<FootballPlayer>
                (p => p.Name.Contains(name) && p.FirstName.Contains(firstName)).ToList<FootballPlayer>();
            foreach (FootballPlayer p in playerToRemove)
                ListFootballPlayer.Remove(p);

        }

        public static List<FootballPlayer> ListFootballPlayer = new List<FootballPlayer>(){
           
            new FootballPlayer("Lloris","Hugo", new DateTime(1986,12,26), "1", 
               new Club[]{
                   new Club("France", "OGC Nice"),
                   new Club("France", "Olympique lyonnais"),
                   new Club("Angleterre", "Tottenham Hotspur")
               }, 
                new PlayerPosition(1, PositionType.Gardien) 
               ),


            new FootballPlayer("Landreau","Mickaël", new DateTime(1979,05,14), "23", 
               new Club[]{
                   new Club("France", "FC Nantes"),
                   new Club("France", "Paris SG"),
                   new Club("France", "Lille OSC"),
                   new Club("France", "SC Bastia")
               }, 
                new PlayerPosition(23, PositionType.Gardien) 
               ),

                new FootballPlayer("Benzema","Karim", new DateTime(1987,12,19), "10", 
                   new Club[]{
                   new Club("France", "Olympique lyonnaise"),
                   new Club("Espagne", "Real Madrid")                
               }, 
                   new PlayerPosition(10, PositionType.Attaquant) 
               ),



            new FootballPlayer("Ruffier","Stéphane", new DateTime(1986,09,27), "16", 
               new Club[]{
                   new Club("France", "AS Monaco"),
                   new Club("France", "Aviron bayonnaise"),
                   new Club("France", "AS Saint-Étienne")
               }, 
                new PlayerPosition(16, PositionType.Gardien) 
               ),


            new FootballPlayer("Sagna","Bacary", new DateTime(1983,02,14), "15", 
               new Club[]{
                   new Club("France", "AJ Auxerre"),
                   new Club("Angleterre", "Arsenal")  
               }, 
                new PlayerPosition(15, PositionType.Défenseur) 
               ),
               new FootballPlayer("Debuchy","Mathieu", new DateTime(1985,07,28), "2", 
               new Club[]{
                   new Club("France", "LOSC Lille"),
                   new Club("Angleterre", "Newcastle United")
               }, 
                new PlayerPosition(2, PositionType.Défenseur) 
               ),


            new FootballPlayer("Sakho","Mamadou", new DateTime(1990,02,13), "5", 
               new Club[]{
                   new Club("France", "Paris SG"),
                   new Club("Angleterre", "Liverpool FC")
               }, 
                new PlayerPosition(5, PositionType.Défenseur) 
               ),


            new FootballPlayer("Koscielny","Laurent", new DateTime(1993,04,25), "21", 
               new Club[]{
                   new Club("France", "EA Guingamp"),
                   new Club("France", "Tours FC"),
                   new Club("France", "FC Lorient"),
                   new Club("Angleterre", "Arsenal")
               }, 
                new PlayerPosition(21, PositionType.Défenseur) 
               ),


            new FootballPlayer("Varane","Raphael", new DateTime(1993,04,25), "4", 
               new Club[]{
                   new Club("France", "France RC Lens"),
                   new Club("Espagne", "Real Madrid")
               }, 
                new PlayerPosition(4, PositionType.Défenseur) 
               ),

                 new FootballPlayer("Mangala","Eliaquim", new DateTime(1991,02,13), "13", 
               new Club[]{
                   new Club("Belgique", "Standard de Liège"),
                   new Club("Portugal", "FC Porto") 
               }, 
                new PlayerPosition(13, PositionType.Défenseur) 
               ),

                 new FootballPlayer("Evra","Patrice", new DateTime(1981,05,15), "3", 
               new Club[]{
                   new Club("Italie", "SC Marsala"),
                   new Club("Italie", "AC Monza"),
                   new Club("France", " OGC Nice"),
                   new Club("France", "AS Monaco"),
                   new Club("Angleterre", "Manchester United")
               }, 
                new PlayerPosition(3, PositionType.Défenseur) 
               ),

                 new FootballPlayer("Digne","Lucas", new DateTime(1993,07,20), "17", 
               new Club[]{
                   new Club("France", "LOSC Lille"),
                   new Club("France", "Paris SG")  
               }, 
                new PlayerPosition(17, PositionType.Défenseur) 
               ),

                new FootballPlayer("Cabay","Yohan", new DateTime(1986,01,14), "6", 
               new Club[]{
                   new Club("France", "France LOSC Lille"),
                   new Club("Angleterre", "ewcastle United"),
                   new Club("France", "Paris Saint-Germain")    
               }, 
                new PlayerPosition(6, PositionType.Milieu) 
               ),
                new FootballPlayer("Matuidi","Blaide", new DateTime(1987,04,09), "14", 
               new Club[]{
                   new Club("France", "ES Troyes AC"),
                   new Club("France", "AS Saint-Étienne"),
                   new Club("France", "Saint-Germain")  
               }, 
                new PlayerPosition(14, PositionType.Milieu) 
               ),
                new FootballPlayer("Sissoko","Moussa", new DateTime(1989,08,16), "18", 
               new Club[]{
                   new Club("France", "Toulouse FC"),
                   new Club("Angleterre", "Newcastle United")  
               }, 
                new PlayerPosition(18, PositionType.Milieu) 
               ),

                new FootballPlayer("Mavuba","Rio", new DateTime(1984,03,08), "12", 
               new Club[]{
                   new Club("France", "Bordeaux"),
                   new Club("Espagne", "Villarreal CF"),
                   new Club("France", "Lille OSC"),
                   new Club("France", "Lille OSC")
               }, 
                new PlayerPosition(12, PositionType.Milieu) 
               ),

                new FootballPlayer("Pogba","Paul", new DateTime(1993,03,15), "19", 
                  new Club[]{
                   new Club("Angleterre", " Manchester Unitede"),
                   new Club("Italie", " Italie Juventus")
               }, 
                   new PlayerPosition(19, PositionType.Milieu) 
               ),

                 new FootballPlayer("Grenier","Clément", new DateTime(1989,11,08), "22", 
               new Club[]{
                   new Club("France", "Olympique Lyonnais")
                
               }, 
                new PlayerPosition(22, PositionType.Milieu) 
               ),

                   new FootballPlayer("Valbuena","Mathieu", new DateTime(1984,09,28), "8", 
               new Club[]{
                   new Club("France", "Olympique de Marseille"),
                
               }, 
                new PlayerPosition(8, PositionType.Attaquant) 
               ),

                   new FootballPlayer("Rémy","Cabella", new DateTime(1990,08,03), "20", 
               new Club[]{
                   new Club("France", "Olympique lyonnais"),
                   new Club("France", "RC Lens"),
                   new Club("France", "OGC Nice"),
                   new Club("France", "Olympique de Marseille"),
                   new Club("Angleterre", "Queens Park Rangers"),
                   new Club("Angleterre", "Newcastle United")
               }, 
                new PlayerPosition(20, PositionType.Attaquant) 
               ),

                    new FootballPlayer("Griezmann","Antoine", new DateTime(1991,03,21), "11", 
               new Club[]{
                   new Club("Espagne","Real Sociedad")
               }, 
                new PlayerPosition(11, PositionType.Attaquant) 
               ),

                    new FootballPlayer("Giroud","Olivier", new DateTime(1986,09,30), "9", 
               new Club[]{
                   new Club("France", "Grenoble Foot"),
                   new Club("France", "FC Istres"),
                   new Club("France", "Tours FC"),
                   new Club("France", "Montpellier HSC"),
                   new Club("Angleterre", "Arsenal FC")
               }, 
                new PlayerPosition(9, PositionType.Attaquant) 
               ),
        };



    }

}
