using System;

namespace Black_Jack
{
    class BlackJack
    {
        Player diler;
        Player plr;
        Deck decka;
        bool flagBet;
        int RoundNumer;
        double bet;

        public BlackJack() { }

        public void StartGame()
        {
            Console.WriteLine("Welcom to my Game! Please enter your name");
            diler = new Player("Diler", 2000);
            plr = new Player(Console.ReadLine(), 2000);
            Console.Clear();
            RoundNumer = 0;
            decka = new Deck();
            Round();
        }


        private void Round()
        {
            while (plr.myMoney > 0 & diler.myMoney > 0)
            {
                Console.Clear();
                RoundNumer++;
                diler.ClearMyHand();
                plr.ClearMyHand();
                if (!flagBet) // validate the last bet
                {
                    Console.WriteLine("Round " + RoundNumer.ToString());
                    Console.WriteLine("Diler money: " + diler.myMoney.ToString());
                    Console.WriteLine(plr.name + " money: " + plr.myMoney.ToString());
                }
                if (flagBet)
                {
                    Console.WriteLine("Your bet is incorrect");
                }
                if (plr.myMoney > 100) // if player set a incorrect bet we throw exeption and say to him "It's bad bet"
                {
                    flagBet = false;
                    Console.WriteLine("Please place your bet (min bet 100)");
                    try
                    {
                        bet = Convert.ToInt32(Console.ReadLine());
                        if (bet < 100 || bet > plr.myMoney)
                        {
                            throw new Exception();
                        }
                    }
                    catch
                    {
                        flagBet = true;
                        continue;
                    }
                }
                if(plr.myMoney < 100)
                {
                    bet = plr.myMoney;
                }
                decka.Refresh();
                plr.TakeCard(decka);
                plr.TakeCard(decka);
                diler.TakeCard(decka);
                VeiwScore();

                while (plr.myPoint < 21) // if player agree he take a new card 
                {
                    Console.WriteLine("Hit you?(yes/something other)");
                    if (Console.ReadLine().ToLower().Equals("yes"))
                    {
                        plr.TakeCard(decka);
                        VeiwScore();
                    }
                    else
                    {
                        break;
                    }
                }

                while(plr.myPoint<21 & diler.myPoint<16) // if diler point less than 16 he take a new card 
                {
                    diler.TakeCard(decka);
                    VeiwScore();
                    Console.WriteLine("Press \"Enter\" to continue");
                    Console.ReadLine();
                }

                if((plr.myPoint<=21 & plr.myPoint > diler.myPoint) || diler.myPoint > 21) // calculate who win
                {
                    if (diler.myMoney - 1.5 * bet > 0)
                    {
                        PlayerWin(1.5 * bet);
                        continue;
                    }
                    if(diler.myMoney - 1.5 * bet <= 0)
                    {
                        PlayerWin(diler.myMoney);
                        SetWinner(plr);
                    }
                }
                if (plr.myPoint < diler.myPoint || plr.myPoint>21)
                {
                    if (plr.myMoney - bet > 0)
                    {
                        DilerWin(bet);
                        if (plr.myMoney == 0)
                        {
                            SetWinner(diler);
                            break;
                        }
                        continue;
                    }
                }
                if(plr.myPoint == diler.myPoint)
                {
                    Stay();
                    continue;
                }

            }
        }

        private void Stay()
        {
            VeiwScore();
            Console.WriteLine("It's stay!");
            Console.WriteLine("Diler money: " + diler.myMoney.ToString());
            Console.WriteLine(plr.name + " money: " + plr.myMoney.ToString());
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();
        }

        private void DilerWin(double Bet)
        {
            plr.MinusMoney(Bet);
            diler.PlusMoney(Bet);
            VeiwScore();
            Console.WriteLine("You lose this round!");
            Console.WriteLine("Diler money: " + diler.myMoney.ToString());
            Console.WriteLine(plr.name + " money: " + plr.myMoney.ToString());
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();
        }

        private void PlayerWin(double Bet)
        {
            diler.MinusMoney(Bet);
            plr.PlusMoney(Bet);
            VeiwScore();
            Console.WriteLine("You win this round!");
            Console.WriteLine("Diler money: " + diler.myMoney.ToString());
            Console.WriteLine(plr.name + " money: " + plr.myMoney.ToString());
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();
        }

        private void VeiwScore() // this method give us player's and diler's cards and points
        {
            Console.Clear();
            plr.CalculateMyPoint();
            diler.CalculateMyPoint();
            Console.WriteLine("Player's cards:");
            plr.VeiwMyCards();
            Console.WriteLine("Player's points: " + plr.myPoint);
            Console.WriteLine("Diler's card:" );
            diler.VeiwMyCards();
            Console.WriteLine("Diler's points: " + diler.myPoint);
        }

        private void SetWinner(Player ChosenPlayer)
        {
            Console.WriteLine("Congratulations!" );
            Console.WriteLine("You win this game!!!");
            Console.WriteLine("Press \"Enter\" to continue");
            Console.ReadLine();
            Environment.Exit(0);
        }
    }
}
