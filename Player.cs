using System;
using System.Collections.Generic;
using System.Text;

namespace AdventGame
{
    class Player
    {
        public string playername;
        public int money = 0;
        public int totalMoney = 0;
        

        public void getName()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("You have no recollection of how you got here.\nIn fact, you are drawing a complete blank on who you even ARE.\nYou search your pockets for a wallet or something that\ncan clue you in on the mystery that is your very own fleshy body.\nAh ha. An ID.");
            Console.WriteLine("What do you see next to name? (Please type your name)");
            playername = Console.ReadLine();
            Console.WriteLine(playername + ", journalist.");
            Console.WriteLine("Now some of it is coming back to you. You remember that\nyou're " + playername + ", an outcast journalist who is trying to prove the\nexistance of paranormal creatures known only in folklore.\nYou were driving to California to get pictures the Fresno Nightcrawlers.\nThe rest is a blank. Somehow you got stuck in the middle of a forest.");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("\nPress any key to continue...");
            Console.ReadKey();
        }
    }
}
