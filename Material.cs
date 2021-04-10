using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;

namespace FinalStudyGuide
{
    class Material
    {
        public void getDef()
        {
            ForegroundColor = ConsoleColor.Cyan;
             
             string DataFile = @"D:\Def.txt";
             string content = "[empty]";

            if (File.Exists(DataFile))
            {
                content = File.ReadAllText(DataFile);
            }
            string[] terms = File.ReadAllLines(DataFile);

            for (int i = 0; i < terms.Length; i++)
            {
                WriteLine(terms[i]);
            }
            ResetColor();
            ReadKey();
        }

        public void getTerms()
        {
            ForegroundColor = ConsoleColor.Cyan;
            string dataFile = @"D:\Terms.txt";
            string Content = "[empty]";

            if (File.Exists(dataFile))
            {
                Content = File.ReadAllText(dataFile);
            }
            string[] Terms = File.ReadAllLines(dataFile);

            for (int i = 0; i < Terms.Length; i++)
            {
                WriteLine(Terms[i]);
            }


            ResetColor();
            ReadKey();
        }

        public void displayRanT()
        {
            ForegroundColor = ConsoleColor.Magenta;
            string ranT;
            ranT = GetRanTerm();

            WriteLine("Bonus Term: " + ranT);
            ResetColor();
            ReadKey();
        }

        public string GetRanTerm()
        {
            string[] bonusT = { "Pseudocode is when your write out the logic without using coding language.", "Relational Operators help check the relation between two operands.", "A logical operator is a symbol that denotes a logical operation." };
            return bonusT[getRan(bonusT.Length)];
        }

        public int getRan(int range)
        {
            Random ran = new Random();
            return ran.Next(range);
        }

    }
}
