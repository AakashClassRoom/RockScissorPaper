using System.Diagnostics;
using System.Runtime.InteropServices;
// rock scissors paper game
using System;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Drawing;

namespace Game
{
    class RockScissorsPaper{
        static void Main(string[] args)
        {
            String Human;
            String Computer;


            System.Console.WriteLine(" Welcome to the game");
            System.Console.WriteLine("Enter any one of the following :- \n 1.Rock \n 2.Scissors \n 3.Paper");

            Random rnd = new Random();
            int ComputerNumber = rnd.Next(1,4); // creates number between 1 and 3 
            // System.Console.WriteLine("The random number is " + ComputerNumber);

            System.Console.Write("Human = " );
            Human = Console.ReadLine();


            
            
            Human = Console.ReadLine();
            
           

        }
    }
}
