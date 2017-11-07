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

        public Player(int money)
        {
            MyMoney = money;
            MyCards = new List<Card>();
            MyPoint = 0;
        }

        public void TakeCard(List<Card> Deck)
        {
            Random pseudo_band = new Random();
            int NumerOfChosenCard = pseudo_band.Next(Deck.Count);
            MyCards.Add(Deck[NumerOfChosenCard]);
            Deck.RemoveAt(NumerOfChosenCard);
        }
        public void VeiwMyCards() { }
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
