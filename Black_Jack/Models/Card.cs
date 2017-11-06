using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Black_Jack.Interfaces;

namespace Black_Jack.Models
{
    class Card : ICard
    {
        string CardName;
        int CardValue;

        public Card(string name, int value)
        {
            CardName = name;
            CardValue = value;
        }

        public string cardName
        {
            get
            {
                return CardName;
            }
        }
        public int cardValue
        {
            get
            {
                return CardValue;
            }
        }

        public Card ChoseCard(List<Card> Deck)
        {
            return new Card("avc", 1);
            
        }

        public void DeleteCardFromDeck(Card chosencard,ref List<Card> Deck) { }

    }
}
