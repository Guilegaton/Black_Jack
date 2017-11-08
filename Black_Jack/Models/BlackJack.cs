using Black_Jack.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Jack
{
    class BlackJack
    {
        Player diler;
        Player plr;

        public BlackJack() { }

        public void StartGame()
        {
            Console.WriteLine("Welcom to our Game! Please enter your name");
            diler = new Player("Diler", 2000);
            plr = new Player(Console.ReadLine(), 2000);
            Console.Clear();

        }


        private void Round()
        {

        }

        private void SetWinner(Player ChosenPlayer)
        {

        }
    }
}
