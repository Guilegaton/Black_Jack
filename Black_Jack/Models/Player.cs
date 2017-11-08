using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Black_Jack.Models;

namespace Black_Jack
{
    class Player : IPlayer
    {
        string Name;
        List<Card> MyCards;
        int MyPoint;
        int MyMoney;

        public int myMoney
        {
            get
            {
                return MyMoney;
            }
        }

        public string name
        {
            get
            {
                return Name;
            }

        }

        public Player(string name, int money)
        {
            Name = name;
            MyMoney = money;
            MyCards = new List<Card>();
            MyPoint = 0;
        }

        public void TakeCard (Deck Decka) => MyCards.Add(Decka.ChoseCard());
        
        public void VeiwMyCards()
        {
            foreach (Card item in MyCards)
            {
                Console.WriteLine(item.cardName);
            }
        }
        public void VeiwMyPoint()
        {
            int point = 0;
            foreach (Card item in MyCards)
            {
                if (point < 11 && item.cardValue == 11)
                    point += 1;
                else
                    point += item.cardValue;
            }
            MyPoint = point;
        }
    }
}
