using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGames
{
    internal class UC2_Random_Number
    {
       
        
            //Position of player
            private int Position = 0;

            //Random method for class
            Random number = new Random();


            public void StartsGame()
            {
                Console.WriteLine("Your position is " + Position);
            }

            public void RandomNumber()
            {
                int Number = number.Next(1, 7);
                Position += Number;
                StartsGame();
                Console.ReadLine();
            }

        
    }
}

