using Black_Jack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack.Interfaces
{
    interface ICard
    {
        Card ChoseCard(List<Card> Deck);
        void DeleteCardFromDeck(Card ChosenCard, ref List<Card> Deck);
    }
}
