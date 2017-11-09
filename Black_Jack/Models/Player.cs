using System;
using System.Collections.Generic;
using Black_Jack.Models;

namespace Black_Jack
{
    class Player : IPlayer
    {
        string Name;
        List<Card> MyCards;
        double MyPoint;
        double MyMoney;

        public double myMoney
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

        public double myPoint
        {
            get
            {
                return MyPoint;
            }
        }

        public Player(string name, int money)
        {
            Name = name;
            MyMoney = money;
            MyCards = new List<Card>();
            MyPoint = 0;
        }

        public void TakeCard(Deck Decka) => MyCards.Add(Decka.ChoseCard());
        public void PlusMoney(double money) => MyMoney += money;
        public void MinusMoney(double money) => MyMoney-= money;
        
        public void VeiwMyCards()
        {
            foreach (Card item in MyCards)
            {
                Console.WriteLine(item.cardName);
            }
        }
        public void CalculateMyPoint()
        {
            int point = 0;
            foreach (Card item in MyCards)
            {
                    point += item.cardValue;
            }
            MyPoint = point;
        }
        public void ClearMyHand()
        {
            MyCards.Clear();
            MyPoint = 0;
        }
    }
}
