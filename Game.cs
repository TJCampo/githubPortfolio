using System;
using System.Collections.Generic;
using System.Text;

namespace TriviaGame
{
    class Game
    {
        TriviaItem trivia = new TriviaItem();
        public void startgame()
        {
            Console.Title = "Trivia Game by Tyler Campo";
            Console.BackgroundColor = ConsoleColor.White;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Magenta;
            Console.WriteLine("TRIVIA GAME by Tyler Campo.");
            Console.WriteLine("Test Your Knowledge...");
            Console.ReadKey();
        }
        public void run()
        {
            startgame();
            trivia.topic();

        }

    }
}
