using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    class Player
    {
        static string playername;
       public static void getname()
        {
            Console.WriteLine("Before we begin, what is your name?");
            playername = Console.ReadLine();
            Console.WriteLine("Welcome to my triva game, " + playername + ".");
            Console.ReadKey();
        }
    }
}
