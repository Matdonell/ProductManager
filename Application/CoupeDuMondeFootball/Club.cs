using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupeDuMondeFootball
{
    public class Club
    {
        public String Name { get; private set; }

        public String Country { get; private set; }

        public Club(String country, String name)
        {
            Name = name;
            Country = country;
        }

        public override string ToString()
        {
            return Country.ToUpper() + " | " + Name;
        }
    }
}
