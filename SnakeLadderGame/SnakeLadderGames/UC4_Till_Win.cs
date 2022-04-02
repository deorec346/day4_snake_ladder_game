using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGames
{
    internal class UC4_Till_Win
    {
        //Position of player
        private int Position = 0;

        //Random method for class
        Random number = new Random();


        public void StartsGame()
        {
            Console.WriteLine("Your position is " + Position);
        }

        //Method To Get Random Number
        public void RandomNumber()
        {
            int Number = number.Next(1, 7);
            Console.WriteLine("\nNumber on Dice " + Number);
            Position += Number;
            Option(Number);
            Check();
            StartsGame();
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
        private void Check()
        {
            if (Position < 0)
            {
                Position = 0;
            }



        }


        //Method for Player Till It Reaches Winning Position}
        public void TillWin()
        {
            while (Position < 100)
                RandomNumber();
            Console.WriteLine("You Won!!");


        }


    }
}
    

