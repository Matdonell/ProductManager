using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoupeDuMondeFootball
{
 

    public class PlayerPosition
    {

        public PositionType Position
        {
            get;
            set;
        }

        public int Number { get; set; }

        public PlayerPosition(int number=0, PositionType position=PositionType.NonDefinie)
        {
            Number = number;
            Position = position;
        }

        public override string ToString()
        {
            return Number + " | " + Position;
        }
    }
}
