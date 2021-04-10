using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventGame
{
    class Menu
    {
        private int SelectedOpt;
        private string[] Options;
        private string DisplayTxt;

        public Menu (string displaytxt, string[] options)
        {
            DisplayTxt = displaytxt;
            Options = options;
            SelectedOpt = 0;
        }

        private void ShowChoices ()
        {
            ResetColor();
            Console.ForegroundColor = ConsoleColor.Cyan;
            WriteLine(DisplayTxt);
            for (int i = 0; i < Options.Length; i++)
            {
                string CurrentOption = Options[i];
                string Prefix;

                if (i == SelectedOpt)
                {
                    Prefix = ">";
                    ForegroundColor = ConsoleColor.Cyan;
                    BackgroundColor = ConsoleColor.Magenta;
                }
                else
                {
                    Prefix = " ";
                    ForegroundColor = ConsoleColor.Cyan;
                    BackgroundColor = ConsoleColor.Black;
                }
                Write($"| {Prefix}{CurrentOption} |");
                ResetColor();
            }

        }

        public int Show()
        {

            ConsoleKey KeyPressed;

            do
            {
                Clear();
                ShowChoices();
                ConsoleKeyInfo KeyInfo = ReadKey(true);
                KeyPressed = KeyInfo.Key;


                if (KeyPressed == ConsoleKey.RightArrow)
                {
                    SelectedOpt++;
                    if(SelectedOpt == Options.Length)
                    {
                        SelectedOpt = 0;
                    }
                }
                else if (KeyPressed == ConsoleKey.LeftArrow)
                {
                    SelectedOpt--;
                    if(SelectedOpt == - 1)
                    {
                        SelectedOpt = Options.Length - 1;
                    }
                }

            } while (KeyPressed != ConsoleKey.Enter);

            return SelectedOpt;
        }
    }
}
