﻿

namespace Black_Jack.Models
{
    class Card
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

    }
}
