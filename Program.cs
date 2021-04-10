using System;
using static System.Console; 
namespace TriviaGame
{
    class Program
    {
        Game game = new Game();
        static void Main(string[] args)
        /* Trivia Game by Tyler Campo
         * Intro to Programming
         * Instructor Biberoglu
         *2/7/21
         *Updated 3/15/21
         *Credit: Canvas Moduels/programmingisfun.com
         *Credit: https://youtu.be/j6ShXTjG5fg 
         */
        {
            Game game = new Game();
            game.run();
        }
    }
}
