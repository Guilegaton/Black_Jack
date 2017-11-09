using Black_Jack.Models;

namespace Black_Jack
{
    interface IPlayer
    {
        void TakeCard(Deck Decka);
        void VeiwMyCards();
        void CalculateMyPoint();
        void MinusMoney(double money);
        void PlusMoney(double money);
        void ClearMyHand();
    }
}
