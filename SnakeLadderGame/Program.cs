using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeLadderGames
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("=============Welcome To Snake And Ladder Game===============");
            UC7_Player_One_And_Player_Two player1 = new UC7_Player_One_And_Player_Two();
            UC7_Player_One_And_Player_Two player2 = new UC7_Player_One_And_Player_Two();
            Console.WriteLine("Player 1: ");
            player1.StartsGame();
            Console.WriteLine("Player 2: ");
            player2.StartsGame();
            player1.TillWin(player2);
            Console.ReadLine();
        }
    }
}