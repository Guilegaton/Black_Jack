using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Black_Jack.Models;

namespace Black_Jack
{
    interface IPlayer
    {
        void TakeCard(Deck Decka);
        void VeiwMyCards();
        void VeiwMyPoint();
    }
}
