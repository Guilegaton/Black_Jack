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
        int MyMoney;

        public int myMoney
        {
            get
            {
                return MyMoney;
            }
        }

        public Player(int money)
        {
            MyMoney = money;
            MyCards = new List<string>();
            MyPoint = 0;
        }

        public void TakeCard() { }
        public void VeiwMyCards() { }
        public void VeiwMyPoint() { }
    }
}
