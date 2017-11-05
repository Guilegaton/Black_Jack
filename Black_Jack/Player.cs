using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class Player : IPlayer
    {
        string Name;
        List<string> MyCards;
        int MyPoint;

        public Player(string name)
        {
            Name = name;
            MyCards = new List<string>();
            MyPoint = 0;
        }


    }
}
