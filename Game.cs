using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace FinalStudyGuide
{
    class Game
    {
        string input;
        public int score;
        string[] alf = {"A) ", "B) ", "C) ", "D) " };
        Material material = new Material();

        public void run()
        {
            start();
            material.getDef();
            material.getTerms();
            material.displayRanT();
            ask1();
            ask2();
            ask3();
            end();
        }

        public void start()
        {
            Clear();
            WriteLine("Study Guide by Tyler Campo.");
            ReadKey();
        }

        public void ask1()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            string[] an1 = {"True.", "34.", "My life decisions.", "++." };
            WriteLine("What best represents a bool?");

            for (int i = 0; i < an1.Length; i++)
            {
                WriteLine(alf[i] + an1[i]);
            }
            ResetColor();

            input = ReadLine();
            if (input.ToLower() == "a")
            {
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                WriteLine("CORRECT!");
                score++;
                ResetColor();
                ReadKey();
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Incorrect.");
                ResetColor();
                ReadKey();
            }

        }

        public void ask2()
        {
            Clear();
            ForegroundColor = ConsoleColor.Blue;
            string[] an2 = { "Magic.", "Repeat a statement until told to stop.", "Creates a blueprint that can be used to creat an object.", "increments an int." };
            WriteLine("What does a loop do?");

            for (int i = 0; i < an2.Length; i++)
            {
                WriteLine(alf[i] + an2[i]);
            }
            ResetColor();

            input = ReadLine();
            if (input.ToLower() == "b")
            {
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                WriteLine("CORRECT!");
                score++;
                ResetColor();
                ReadKey();
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Incorrect.");
                ResetColor();
                ReadKey();
                
            }

        }

        public void ask3()
        {
            Clear();
            ForegroundColor = ConsoleColor.Magenta;
            string[] an3 = { "Logic that is written out that isn't in a programming language.", "A fictitious name used by an author.", "42.", "Object-oriented." };
            WriteLine("BONUS QUESTION> WORTH EXTRA!");
            WriteLine("What is Pseudocode?");

            for (int i = 0; i < an3.Length; i++)
            {
                WriteLine(alf[i] + an3[i]);
            }
            ResetColor();

            input = ReadLine();
            if (input.ToLower() == "a")
            {
                ForegroundColor = ConsoleColor.White;
                BackgroundColor = ConsoleColor.Green;
                WriteLine("CORRECT!");
                score++;
                score++;
                ResetColor();
                ReadKey();
            }
            else
            {
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Incorrect.");
                ResetColor();
                ReadKey();
            }

        }


        public void end()
        {
            WriteLine("Well done on finishing the study guide.");
            WriteLine("Your score is: " + score);
            WriteLine("Would you like to play again? Y or N?");
            input = ReadLine();
            if (input == "y")
            {
                run();
            }
            else
            {
                WriteLine("Press any key to exit...");
                ReadKey();
            }

        }


    }
}
