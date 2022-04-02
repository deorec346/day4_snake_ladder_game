using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGames
{
    internal class UC7_Player_One_And_Player_Two
    {
        //Position of player
        private int Position = 0;
        private bool WinningCheck = false;
        private int TotalDieRoll = 0;

        //Random method for class
        Random number = new Random();


        public void StartsGame()
        {
            Console.WriteLine("Your position is " + Position);
        }

        //Method To Get Random Number
        public void RandomNumber()
        {
            TotalDieRoll++;
            int CheckContinue = 0;
            int Number = number.Next(1, 7);
            Console.WriteLine("\nNumber on Dice " + Number);
            if (WinningCheck is false)
                CheckContinue = MovePlayer(Number);
            if (WinningCheck is false && CheckContinue == 1)
                Option(Number);

        }

        //Method To Get Option For Play
        public void Option(int Number)
        {
            int OptionForPlay = number.Next(0, 3);

            switch (OptionForPlay)
            {
                case 0:
                    Console.WriteLine("No Play");
                    break;

                case 1:
                    Console.WriteLine("You Got A Ladder!!");
                    Console.WriteLine("Moves Ahead by " + Number);
                    Position += Number;
                    break;

                case 2:
                    Console.WriteLine("Oh No!! Snake Trap ");
                    Console.WriteLine("Moves Behind by " + Number);
                    Position -= Number;
                    break;

                default:
                    Console.WriteLine("Error!!");
                    break;
            }
        }

        private int Check(int displacement)
        {
            if (Position < 0)
            {
                Position = 0;
                return 0;
            }
            else if (Position > 100)
            {
                Position -= displacement;
                Console.WriteLine("Oops! Your Position Is More Than 100");
                Console.WriteLine("You are moved Behind to previous position");
                return 0;
            }
            else
                return 1;
        }

        private int MovePlayer(int displacement)
        {
            Position += displacement;
            if (Position == 100)
            {
                WinningCheck = true;
                return 0;
            }
            return Check(displacement);
        }


        public void TillWin(UC7_Player_One_And_Player_Two player2)
        {
            while (this.WinningCheck is false && player2.WinningCheck is false)
            {
                Console.WriteLine("\nPlayer 1 turn: ");
                this.RandomNumber();
                this.StartsGame();
                if (this.WinningCheck is true)
                    break;
                Console.WriteLine("\nPlayer 2 turn: ");
                player2.RandomNumber();
                player2.StartsGame();
            }
            if (player2.WinningCheck is true)
                Console.WriteLine("\nCongratulations Player 2!! You Won!!");
            else
                Console.WriteLine("\nCongratulations Player 1!! You Won!!");
            Console.WriteLine("Player 1 Total die rolls: " + this.TotalDieRoll);
            Console.WriteLine("Player 2 Total die rolls: " + player2.TotalDieRoll);
        }


    }
}
    
