using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using System.IO;
using System.Linq;

namespace TriviaGame
{
    
    class TriviaItem
    {
        public int score;
        public int turn;
        public string input;
        public string[] conclusion = { "Correct", "Incorrect" };
        public string[] questionset1 = { 
            "True(T) or false(F)? No matter what kind, a guitar always has six strings.",
            "Which one of these names is a guitar brand?\nA) equate.\nB) Gibby.\nW) Westman.\nD) Ibanez.",
            "In general, how many frets does a guitar have? Type a number between 1 and 39",
            "What kind of guitar was Jimi Hendrix's famous \"Woodstock Strat?\"\nA) A black Fender (\"The Black Beauty\")\nB) A cherry Epiphone.\nC) A white Fender.\nD) A Jackson Kelly.",
            "Which one of these famous acoustic songs is forbidden from being played at guitar stores?\nA) Stairway to Heaven.\nB) Wonderwall.\nC) Wagon Wheel.\nD) Here Comes the Sun.",
            "True(T) or false(F)? Taylor Guitars was founded in the early 2000s",
            "Choose the best word to end the sentence: \"Anyway, here's _______\"\nA) \"Your crappy strat.\"\nB) \"Headstock.\"\nC) Pick.\nD Wonderwall. ",
            "From thickest to thinnest, type the letters associated with the 6 strings on a typical guitar.(Ex.\"ABCDEF\")",
            "Who played the guitar solo on Pink Floyd's \"Comfortably Numb?\"\nA) Roger Waters.\nB) David Gilmore.\nC) Jimmy Page.\nD) Flea.",
            "What is hammering?\nA) Hitting the fretboard with your fist to look cool.\nB) Slamming your fretting finger on a string to hit a note without strumming\nC) Using the palm of your strumming hand to hit the strings and mute them.\nD) Something Eddie Van Halen was famous for.", };
        public string[] questionset2 = {"What was the first game?\nA) Tetris.\nB) Mario.\nC) Pong.\nD) Donkey Kong.", "Which studio made Apex Legends?\nA) Naughty Dog.\nB) EA.\nC) Bethesda.\nD) Respawn.","True or False. Sony owns PlayStation.(T,F).", "Which video game franchise is famous for it'd difficulty?\nA) Dark Souls.\nB) Call of Duty.\nC) Pokemon.\nD) Hell Knights.", "True of False. Cuphead has a guinness world record for its whopping 50,000 hand drawn frames. (T,F).", "Who is credited as being the father of video games?\nA) Ralph Baer.\nB) Dan Wiltshire\nC) Robert Kiyosaki\nD) Neil Foster.", "What is highest selling video game ever made?\nA) GTA V.\nB) Tetris.\nC) Minecraft.\nD) Fortnite.", "What genre of game is Fortnite?\nA) Open-world RPG.\nB) Battle Royal.\nC) First-person shooter.\nD) JRPG.", "What is the classic adventure game where we play as a boy in a green outfit?\nA) Super Mario Bros.\nB) NieR Automata.\nC) Pikmin.\nD) Legend of Zelda.", "Which platform has the most gamers?\nA) PlayStation.\nB) Nintendo Switch.\nC) Mobile phones.\nD) Xbox." };
        public string[] questionset3 = { "What kind of animal is a Kangaroo?\nA) Rodent.\nB) Mammal.\nC) Marsupial.\nD) Reptile.", "Truth or False. If you see a racoon outside during the day it has rabies. (T,F).", "What gorilla was killed in 2016 and became a legendary figure on the internet?\nA) Lucy.\nB) Colo.\nC) Tarzan.\nD) Harambe.", "What kind of animal is the oldest animal on the planet?\nA) Parrot.\nB) Tortoise.\nC) Turtle.\nD) Orca Whale.", "What color skin does a Zebra have?\nA) Black.\nB) White.\nC) Tan.\nD) Grey.", "What bird is associated with Charles Darwin?\nA) Cockatoo.\nB) Finch.\nC) Flamingo.\nD) Birb.", "By household, which is the most popular house pet?\nA) Cat.\nB) Fish.\nC) Bunny.\nD) Dog.", "How many millions of fish are domesticated? Please type your answer. (Ex.20 NOT 20 million).", "True or False. Wojtek was a bear officially enlisted in the polish army in 1943 and earned the rank of Corporal. (T,F).", "What was the name of the cat that survived the sinking of 3 ships?\nA) Unsinkable Sam.\nB) Lt. Ducky.\nC) Poseidon.\nD) Omen." };

        public void topic()
        {
            Clear();
            WriteLine("Please choose a topic.\n1) Guitars.\n2) Video Games.\n3)Animals.");
            input = ReadLine();

            if (Convert.ToInt32(input) == 1)
            {
                Quesions1();
            }
            else if(Convert.ToInt32(input) == 2)
            {
                Quesions2();
            }
            else if (Convert.ToInt32(input) == 3)
            {
                Quesions3();
            }
            else
            {
                WriteLine("Please Choose a valid option.");
                ReadKey();
                topic();
            }
        }
   

        public void endgame()
        {
            WriteLine("Congratulations on finishing the quiz.");
            WriteLine("Your final score is " + score);

            string HCdata = @"D:\HighScores.txt";
            List<string> scores = new List<string>();
            scores = File.ReadAllLines(HCdata).ToList();

            foreach (string score in scores)
            {
                WriteLine(score);
            }

            scores.Add(Convert.ToString(score));

            File.WriteAllLines(HCdata, scores);
             
            WriteLine("Press (r) to return to topic select. Press (e) to exit.");
            input = ReadLine();

            if(input.ToLower() == "r")
            {
                topic();
            }
            else
            {
                WriteLine("Press any key to exit...");
            }

        }

        public void Quesions1()
        {
            turn = 0;
            //1
            newTurn();
            WriteLine(questionset1[0]);
            input = ReadLine();

            if (input.ToUpper() == "F")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //2
            newTurn();
            WriteLine(questionset1[1]);
            input = ReadLine();

            if (input.ToUpper() == "D")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //3
            newTurn();
            WriteLine(questionset1[2]);
            input = ReadLine();

            if (input.ToUpper() == "22")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //4
            newTurn();
            WriteLine(questionset1[3]);
            input = ReadLine();

            if (input.ToUpper() == "C")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //5
            newTurn();
            WriteLine(questionset1[4]);
            input = ReadLine();

            if (input.ToUpper() == "A")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //6
            newTurn();
            WriteLine(questionset1[5]);
            input = ReadLine();

            if (input.ToUpper() == "F")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //7
            newTurn();
            WriteLine(questionset1[6]);
            input = ReadLine();

            if (input.ToUpper() == "D")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //8
            newTurn();
            WriteLine(questionset1[7]);
            input = ReadLine();

            if (input.ToUpper() == "EADGBE")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //9
            newTurn();
            WriteLine(questionset1[8]);
            input = ReadLine();

            if (input.ToUpper() == "B")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //10
            newTurn();
            WriteLine(questionset1[9]);
            input = ReadLine();

            if (input.ToUpper() == "B")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();
            endgame();
        }


        public void Quesions2()
        {
            turn = 0;
            //1
            newTurn();
            WriteLine(questionset2[0]);
            input = ReadLine();

            if (input.ToUpper() == "C")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //2
            newTurn();
            WriteLine(questionset2[1]);
            input = ReadLine();

            if (input.ToUpper() == "D")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //3
            newTurn();
            WriteLine(questionset2[2]);
            input = ReadLine();

            if (input.ToUpper() == "T")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //4
            newTurn();
            WriteLine(questionset2[3]);
            input = ReadLine();

            if (input.ToUpper() == "A")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //5
            newTurn();
            WriteLine(questionset2[4]);
            input = ReadLine();

            if (input.ToUpper() == "T")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //6
            newTurn();
            WriteLine(questionset2[5]);
            input = ReadLine();

            if (input.ToUpper() == "A")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //7
            newTurn();
            WriteLine(questionset2[6]);
            input = ReadLine();

            if (input.ToUpper() == "C")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //8
            newTurn();
            WriteLine(questionset2[7]);
            input = ReadLine();

            if (input.ToUpper() == "B")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //9
            newTurn();
            WriteLine(questionset2[8]);
            input = ReadLine();

            if (input.ToUpper() == "D")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //10
            newTurn();
            WriteLine(questionset2[9]);
            input = ReadLine();

            if (input.ToUpper() == "C")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();
            endgame();
        }

        public void Quesions3()
        {
            turn = 0;
            //1
            newTurn();
            WriteLine(questionset3[0]);
            input = ReadLine();

            if (input.ToUpper() == "C")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //2
            newTurn();
            WriteLine(questionset3[1]);
            input = ReadLine();

            if (input.ToUpper() == "F")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //3
            newTurn();
            WriteLine(questionset3[2]);
            input = ReadLine();

            if (input.ToUpper() == "D")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //4
            newTurn();
            WriteLine(questionset3[3]);
            input = ReadLine();

            if (input.ToUpper() == "B")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //5
            newTurn();
            WriteLine(questionset3[4]);
            input = ReadLine();

            if (input.ToUpper() == "A")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //6
            newTurn();
            WriteLine(questionset3[5]);
            input = ReadLine();

            if (input.ToUpper() == "B")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //7
            newTurn();
            WriteLine(questionset3[6]);
            input = ReadLine();

            if (input.ToUpper() == "D")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //8
            newTurn();
            WriteLine(questionset3[7]);
            input = ReadLine();

            if (input.ToUpper() == "142")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //9
            newTurn();
            WriteLine(questionset3[8]);
            input = ReadLine();

            if (input.ToUpper() == "T")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();

            //10
            newTurn();
            WriteLine(questionset3[9]);
            input = ReadLine();

            if (input.ToUpper() == "A")
            {
                rightAnswer();
            }
            else
            {
                wrongAnswer();
            }
            ResetColor();
            ReadKey();
            endgame();
        }

        public void newTurn()
        {
            Clear();
            turn++;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Magenta;
        }

        public void wrongAnswer()
        {
            ForegroundColor = ConsoleColor.Red;
            WriteLine(conclusion[1]);
            ResetColor();
            WriteLine("Your score is: " + score);
            WriteLine("Current Turn: " + turn + "\\10");
            ReadKey();
        }

        public void rightAnswer()
        {
            ResetColor();
            ForegroundColor = ConsoleColor.Green;
            WriteLine(conclusion[0]);
            ResetColor();
            score++;
            WriteLine("Your score is: " + score);
            WriteLine("Current Turn: " + turn + "\\10");
            ReadKey();
        }
    }
}
