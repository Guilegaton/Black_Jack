using Black_Jack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class BlackJack : IBlackJack
    {
        public BlackJack() { }

        public void StartGame()
        {
            List<Card> Deck = SetStartDeck();
        }

        private void VeiwAllPoint(Player ChosenPlayer)
        {

        }

        public void SetWinner(Player ChosenPlayer)
        {

        }

        private List<Card> SetStartDeck()
        {
            //first time i will use "if"
            string[] CardName = new string[] { "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "Bishop", "Queen", "King", "Tuz" };
            string[] CardMast = new string[] { "chervi", "bubna", "trefa", "picka" };
            List<Card> Deck = new List<Card>();
            for (int i = 2; i < CardName.Length + 2; i++)
            {
                for (int j = 0; j < CardMast.Length; j++)
                {
                    if (i < 11)
                        Deck.Add(new Card(CardName[i - 2] + " " + CardMast[j], i));
                    else if(i>10 && i != 14)
                        Deck.Add(new Card(CardName[i - 2] + " " + CardMast[j], 10));
                    else if(i == 14)
                        Deck.Add(new Card(CardName[i - 2] + " " + CardMast[j], 11));
                }
            }
            foreach (Card item in Deck)
            {
                Console.WriteLine(item.cardName + " " + item.cardValue.ToString());
            }
            return Deck;
        }
    }
}
