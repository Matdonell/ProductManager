using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupeDuMondeFootball
{

   /*
    * LENHARTOVA Sébastien
    * CHARLES Pierre
    * Groupe 5
    * Mini projet coupe du monde de football 
    */

    class Test
    {
        public Test()
        {

            FootballTeam team = new FootballTeam();
            team.Display();
            Console.WriteLine(" Ajout de deux joueurs ( sans club )");
            team.AddPlayer("Steve", "Mandanda", new DateTime(1985, 03, 28), 30, PositionType.Gardien);
            team.AddPlayer("Mamadou", "Sakho", new DateTime(1990, 02, 13), 17, PositionType.Défenseur);
            team.Display();
            Console.WriteLine("Supression du joueur Steve");
            team.RemovePlayer("Steve", "Mandanda");
            team.Display();

        }

    }

}

