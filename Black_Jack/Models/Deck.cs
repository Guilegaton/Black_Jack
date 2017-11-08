using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Black_Jack.Models;

namespace Black_Jack
{
    class Deck
    {
        List<Card> Decka;

        public Deck()
        {
            Decka = new List<Card>();
            Refresh();
        }

        internal List<Card> decka
        {
            get
            {
                return Decka;
            }
        }

        public Card ChoseCard()
        {
            Random pseudo_band = new Random();
            int NumerOfChosenCard = pseudo_band.Next(decka.Count);
            Card chosencard = decka[NumerOfChosenCard];
            Decka.RemoveAt(NumerOfChosenCard);
            return chosencard;
        }

        public void Refresh()
        {
            Decka.Clear();
            string[] CardName = new string[] { "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "Jack", "Queen", "King", "Ace" };
            string[] CardMast = new string[] { "hearts", "diamonds", "peak", "clubs" };
            for (int i = 2; i < CardName.Length + 2; i++)
            {
                for (int j = 0; j < CardMast.Length; j++)
                {
                    if (i < 11)
                        Decka.Add(new Card(CardName[i - 2] + " " + CardMast[j], i));
                    else if (i > 10 && i != 14)
                        Decka.Add(new Card(CardName[i - 2] + " " + CardMast[j], 10));
                    else if (i == 14)
                        Decka.Add(new Card(CardName[i - 2] + " " + CardMast[j], 11));
                }
            }
        }
    }
}
