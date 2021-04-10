using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventGame
{
    class Game
    {
        public string input;
        public string PWInput;
        public bool FirstTime1 = true;
        public bool FirstTime2 = true;
        public bool FirstTime3 = true;
        public bool FirstTime4 = true;
        public bool PwFind = false;
        public int End;
        Items RareCoin = new Items("Rare Coin (A silver dollar with President Dwight D. Eisenhower's face on it).", false);
        Items cigPac = new Items("Cigarette Pack (Premium cigarettes. Lifeblood of the chain-smoker).", false);
        Items stick = new Items("Tough Stick (A strong looking stick. The possibilities are infinite).", false);
        Items rock = new Items("Rock (A despicable metamorphic rock that tripped you for no good reason.)", false);
        Items glass = new Items("Chunk of Glass (A terribly dangerous item that you dutifully picked up to recycle).", false);
        Items rose = new Items("Rose (A beautiful rose plucked from a bush located within a treacherous path in the woods).", false);
        Items wrapper = new Items("Candy Wrapper (Useless wrapper sold to make you waste your money).", false);
        Items capyCigs = new Items("Capybara Cigarettes (The favorite brand of cigarettes among those with good taste).", false);
        Items towerKey = new Items("Tower Key (A key that unlocks the fence surrounding the radio tower.)", false);
        NPCs jose = new NPCs()
        {
            NPCname = "Jose",
            Greeting = "\"I see you, human\"."

        };
        MerchantPhrog phrog = new MerchantPhrog()
        {
            NPCname = "Phrog",
            Greeting = "\"Howdy, stranger\"."

        };

        static List<string> Inventory = new List<string>();
        
        Player player = new Player();



        public void title()
        {

            BackgroundColor = ConsoleColor.Cyan;
            ForegroundColor = ConsoleColor.Black;
            WriteLine(@"
   \  |                     | _)  |        _ \ _)  |             _)                                
  |\/ |   _ \   _ \  __ \   |  |  __|     |   | |  |   _` |   __| |  __ `__ \    _` |   _` |   _ \ 
  |   |  (   | (   | |   |  |  |  |       ___/  |  |  (   |  |    |  |   |   |  (   |  (   |   __/ 
 _|  _| \___/ \___/ _|  _| _| _| \__|    _|    _| _| \__, | _|   _| _|  _|  _| \__,_| \__, | \___| 
                                                     |___/                            |___/        
");
            ResetColor();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("A game by Tyler Campo.");
            ResetColor();

            BottomPrompt();
        }

        public void run()
        {
            title();
            start();
            player.getName();
            intro();
            RunMenu();
        }
        public void start()
        {

            Clear();
            ResetColor();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("You wake up and find yourself in a clearing in a forest.");
            WriteLine("It is the middle of the night. A full moon hangs low in\nthe sky, bathing everything in a celestial blue shimmer.");
            WriteLine("Looming over the tall trees is a radio tower. Everywhere\nelse is just trees as far as the eye can see. It seems\nthat making your way to the tower is the best course of action.");

            BottomPrompt();
        }

        public void intro()
        {
            Clear();
            ResetColor();
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine("You want to get your bearings before anything else, so you decide to explore the clearing a bit.\nYou can look behind the boulders(A) or check out what that sapling has going on(B).\nPlease type A or B.");
            input = ReadLine();
            input = input.ToLower();
            if (input == "a")
            {
                ResetColor();
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("There isn't much besides dirt behind the big boys (or girls),\nbut Wedged within the Earth is a perfect circle. On closer\ninspection you see it's a dollar coin. You thought these\nthings were all gone! You pluck it from the ground and wipe\nit clean. It's lost most of its luster, shining only dully.\nYou find the date. 1969.");
                Inventory.Add(RareCoin.itemName);
                RareCoin.obtained = true;
                ReadLine();
                RunMenu();

            }
            else if (input == "b")
            {
                ResetColor();
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("The sapling seems to be chilling. Next to it you find a cigarette pack.\nIt appears to have been stepped on. Inside are a few crushed Cigarettes.\nIt's gross, but for some reason you pick it up. You get the feeling\nthat it might be important later.");
                Inventory.Add(cigPac.itemName);
                cigPac.obtained = true;
                ReadLine();
                RunMenu();
            }
            else
            {
                ResetColor();
                ForegroundColor = ConsoleColor.Red;
                WriteLine("Please choose a valid path.");
                ReadLine();
                intro();


            }
        }

        private void RunMenu()
        {
            string displaytxt = "You stand in the forest debating on where to go.";
            string[] options = { "Explore the light in the trees.", "Explore the narrow path", "Walk towards the radio tower", "Inventory", "Exit" };
            Menu MainMenu = new Menu(displaytxt, options);
            int selectedOpt = MainMenu.Show();

            switch (selectedOpt)
            {
                case 0:
                    Location1();
                    break;
                case 1:
                    location2();
                    break;
                case 2:
                    location3();
                    break;

                case 3:
                    inventory();
                    break;

                case 4:
                    WriteLine("\n\nPress any key to exit...");
                    ReadKey(true);
                    Environment.Exit(0);
                    break;
            }
        }

        public void RunPhrogMenu()
        {
            string displaytxt = "You sit across the frogman and his shop.";
            string[] wares = { "And you are?", "Advice", "Shop", "Exit" };
            Menu MainMenu = new Menu(displaytxt, wares);
            int selectedOpt = MainMenu.Show();

            switch (selectedOpt)
            {
                case 0:
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine($"\n\nI am a wiser frogman. Name's {phrog.NPCname}. I'm not weighed down by petty ambition like you or my brother. I make a simple living. It really is the best way to live. Wouldn't you agree?");

                    BottomPrompt();

                    RunPhrogMenu();
                    break;
                case 1:
                    phrog.temptation();
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("\n\nDo you walk through the door?\n1. Yes.\n2.No.");

                    input = ReadLine();
                    if (input == "1")
                    {
                        End = 2;
                        Ending();
                    }
                    else if (input == "2")
                    {
                        RunPhrogMenu();
                    }
                    else
                    {
                        Clear();
                        ResetColor();
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("Please choose a valid choice.");
                        ReadLine();
                        RunPhrogMenu();
                    }
                    break;
                case 2:
                    PhrogShop();
                    break;

                case 3:
                    RunMenu();
                    break;

            }
        }
        public void PhrogShop()
        {


            string displaytxt = $"Take a look at my wares.\n\nCurrent Money: {player.money:c}";
            string[] wares = { "Candy Wrapper($1)", "Capybara Cigarettes($2)", "Tower Key($3)", "Exit" };
            Menu MainMenu = new Menu(displaytxt, wares);
            int selectedOpt = MainMenu.Show();

            switch (selectedOpt)
            {
                case 0:
                    if (wrapper.obtained == false && player.money >= 1)
                    {
                        ResetColor();
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("\n\nHere you are. That item is absolutly useless by the way");
                        Inventory.Add(wrapper.itemName);
                        wrapper.obtained = true;
                        player.money--;

                        BottomPrompt();

                        PhrogShop();
                    }
                    else
                    {
                        ResetColor();
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("\n\nNo can do, buckaroo.");

                        BottomPrompt();

                        PhrogShop();
                    }

                    break;
                case 1:
                    if (capyCigs.obtained == false && player.money >= 2)
                    {
                        ResetColor();
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("\n\nThere you go. That's my brother's favorite brand of cigarettes by the way.");
                        Inventory.Add(capyCigs.itemName);
                        capyCigs.obtained = true;
                        player.money--;
                        player.money--;

                        BottomPrompt();

                        PhrogShop();
                    }
                    else
                    {
                        ResetColor();
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("\n\nNo can do, buckaroo.");

                        BottomPrompt();

                        PhrogShop();
                    }
                    break;
                case 2:
                    if (towerKey.obtained == false && player.money >= 3)
                    {
                        ResetColor();
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("\n\nTsk. Here is your key.");
                        Inventory.Add(towerKey.itemName);
                        towerKey.obtained = true;
                        player.money--;
                        player.money--;
                        player.money--;

                        BottomPrompt();

                        PhrogShop();
                    }
                    else
                    {
                        ResetColor();
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("\n\nNo can do, buckaroo.");

                        BottomPrompt();

                        PhrogShop();
                    }
                    break;

                case 3:
                    ReadLine();
                    RunPhrogMenu();
                    break;

            }

        }

        public void RunJoseMenu()
        {
            ResetColor();
            ForegroundColor = ConsoleColor.Yellow;
            string displaytxt = "You and the frog are vibing next to the campfire. He begins to doodle on sketch pad that's comically big compared to him. You are filled with questions.";
            string[] options = { "\"I thought Frogmen lived in Ohio?\"", "\"What are you doing here?\"", "\"What is this place?\"", "Exit" };
            Menu JoseMenu = new Menu(displaytxt, options);
            int selectedOpt = JoseMenu.Show();
            switch (selectedOpt)
            {
                case 0:
                    ResetColor();
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\n\n\"Yeah that's where most of us are born, but it's not like all of us stay in Ohio. We travel just like humans. You are very far from home yourself.\"");

                    BottomPrompt();

                    RunJoseMenu();
                    break;

                case 1:
                    ResetColor();
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\n\n\"I'm trying to get up, my guy.\" He holds up the sketchbook. An ugly, but very stylish frog is drawn on the paper. It's really good. You find it hard to believe a frog drew that.\"");

                    BottomPrompt();

                    RunJoseMenu();
                    break;

                case 2:
                    ResetColor();
                    ForegroundColor = ConsoleColor.Yellow;
                    WriteLine("\n\nYou don't know?\nWell... let's just say all of us folklore creatures come together once every year. We celebrate our anonymity among the humans.\n... You are a special exception, it seems. ");

                    BottomPrompt();

                    RunJoseMenu();
                    break;

                case 3:
                    ResetColor();
                    RunMenu();
                    break;
            }
        }

        public void RunAreaMenu()
        {
            ResetColor();
            ForegroundColor = ConsoleColor.Green;
            string displaytxt = "You are stopped by a tall, wooden fence that appears to stretch for miles. You walk up to the door and knock. A raspy voice repeats the word \"Password...\" over and over.";
            string[] options = { "Gate Door", "Explore Area", "Exit" };
            Menu AreaMenu = new Menu(displaytxt, options);
            int selectedOpt = AreaMenu.Show();
            switch (selectedOpt)
            {
                case 0:
                    ResetColor();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("\n\n\"Password... (Please type the password.\n Hint: It's a name.)");
                    input = ReadLine();
                    PWInput = input;
                    if (input.ToLower() == "sarah")
                    {
                        PwFind = true;
                        ReadLine();
                        ResetColor();
                        MonsterClearing();
                    }
                    else
                    {
                        ReadLine();
                        ResetColor();
                        RunAreaMenu();
                    }
                    ReadLine();
                    ResetColor();

                    break;

                case 1:
                    ResetColor();
                    ForegroundColor = ConsoleColor.Green;
                    string RanTxt;
                    RanTxt = RanText();

                    WriteLine("\n\n" + RanTxt);

                    BottomPrompt();

                    RunAreaMenu();

                    break;

                case 2:
                    ResetColor();
                    RunMenu();
                    break;
            }
        }

        public void inventory()
        {
            ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"\nCurrent Wallet: {player.money}");
            for (int i = 0; i < Inventory.Count; i++)
            {

                WriteLine("\n" + Inventory[i]);

            }
            ResetColor();
            ReadLine();
            RunMenu();
        }

        public void Location1()
        {
            Clear();
            ResetColor();
            ForegroundColor = ConsoleColor.Yellow;


            if (FirstTime1 == true)
            {
                WriteLine("You walk through the woods. The moonlight seeps through the leaves. A white light illuminates all.\nA different light catches your eye, however. The orange glow of a campfire.");
                WriteLine("You tiptoe over and hide in a bush. Scanning the environment you see something incredible.");
                WriteLine($"A frog that stands at least 3-foot tall. He's nonchalantly leaning on a tree, head tilted up,\nlooking at the moon. In one hand he holds a stick that he occasionally pokes the fire with.\nNext to him is a tiny radio playing Kanye West. This is by far the coolest frog you've ever seen.\n{jose.Greeting} He says.");

                BottomPrompt();

                if (cigPac.obtained == true)
                {
                    WriteLine("Staring at the pack of cigarettes he says:\"You gonna smoke those?\" You toss a cigarette towards him.\nIn return he uses a froggy finger to flick a dollar coin at you. You catch it easily. It was an\nexcelent flick.");
                    WriteLine("\n\"My addiction,\" He says placing a crumpled cigarette in his mouth and leaning over the fire to light it.");
                    WriteLine("\"Won't you join me? It's not like a 3 foot frog can hurt you.\" You sit by the frog with a nicotine addiction.");
                    player.money++;
                    player.totalMoney++;
                }
                else
                {
                    WriteLine("The frog points to the coin in your hand.\"That's an old coin there, my guy. My brother will be\nvery pleased about that. There are other frogmen like me in this forest. They are merchants trying\nto make a living here. I'd hate to see you spend that beauty though.\" He flicks another coin at you");
                    WriteLine("\"Come join me. I'm a small frog, it's not like I can hurt you.\" You sit by the fire with the little guy.");
                    player.money++;
                    player.totalMoney++;
                }

                if (player.playername == "ye")
                {
                    WriteLine("\n\"Wait are you who I think you are?\"\n...\n\"OH MY GOD! KANYE WEST! I'M YOUR BIGGEST FAN. TAKE ALL MY MONEY.\"");
                    player.money++;
                    player.money++;
                    player.money++;
                    player.money++;
                    player.money++;
                    player.totalMoney++;
                    player.totalMoney++;
                    player.totalMoney++;
                    player.totalMoney++;
                    player.totalMoney++;
                }

                BottomPrompt();

                FirstTime1 = false;
            }
            if (capyCigs.obtained == true)
            {
                WriteLine("\"Are those Capybara Cigarettes? That's my favorite brand! Hey, I think I can help you with your goal to find the Nightcrawlers. All you need to do is give me those cigarettes.\"\n\"How did you know I want to find the Nightcrawlers?\"\n\"Let's just say we’re more acquainted than you think. So what do you say?\"\n1. Yes\n2. Not now.");
                input = ReadLine();

                if (input == "1")
                {
                    WriteLine("The frogman takes you deeper into the woods.\nHe finished the entire pack before you two reach your destination.\nHe peels back the branches of a bush.\nUnbelievable! It's half a dozen Fresno Nightcrawlers frolicking in a meadow.\nYou take out your camera and snap pictures left and right. You can't believe it.\nAfter all these years you finally have proof of a species thought only to exist in stories.\nTears cloud your vision. It is like the most beautiful dream.");
                    ReadLine();
                    End = 3;
                    Ending();
                }
                else if (input == "2")
                {
                    RunJoseMenu();
                }
                else
                {
                    ResetColor();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Please choose a valid choice.");
                    ReadLine();
                    Location1();
                }
            }
            RunJoseMenu();


            BottomPrompt();

            RunMenu();

        }

        public void location2()
        {
            Clear();
            ResetColor();
            ForegroundColor = ConsoleColor.Blue;

            if (FirstTime2 == true)
            {
                WriteLine("The narrow path forks between a opening in the trees(A) and group of bushes(B).\nPlease type A or B.");
                input = ReadLine();
                input = input.ToLower();

                if (input == "a")
                {
                    WriteLine("You charge forward into the trees. Many branches lay around. One looks suitable\nas a walking stick so you pick it up. You swing it around a bit. It's a high\nquality stick so you decide to keep it.");
                    ReadLine();
                    Inventory.Add(stick.itemName);
                    stick.obtained = true;
                }
                else if (input == "b")
                {
                    WriteLine("You stumble through the bushes. You honestly don't know why you decided to walk\nright through the prickly bush. Distracted, you trip on a rock and fall on\nyour face. It was your fault, but you still get mad at the rock. As revenge you\ntake the rock prisoner. You'll find a nice river to throw it into.");
                    ReadLine();
                    Inventory.Add(rock.itemName);
                    rock.obtained = true;
                }
                else
                {
                    ResetColor();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Please choose a valid path.");
                    ResetColor();
                    ReadLine();
                    location2();
                }
                ForegroundColor = ConsoleColor.Blue;
                Clear();
                WriteLine("You wander the woods for a while and find a part in the trees.\nThe part is caused by a river. Moonlight floods the opening turning\nthe water white. You can't make out how deep it is.");

                BottomPrompt();

                if (stick.obtained == true)
                {
                    Clear();
                    ResetColor();
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("Luckily you have this stick. You first thought is that you'll\nbe able to finally prove that you could've been a great pole vaulter.");
                    WriteLine("You step back. You have an excellent running start. You thrust\nthe large stick into the river and hurl yourself over the water.\nFor a few glorious moments you are suspended in the air.\nYour work done and your fate left to gravity. Such perfect form.\n\"YOU WERE WRONG DAD. I COULD'VE MADE IT. JUST LOOK AT ME.\"\nAll those wasted years working for a magazine... If only you\nhad the confidence to follow your dreams when you were younger,\nbut maybe this proves you still can-");
                    WriteLine("You land on the grass on the other side with a painful thud.\nYou stuck the landing by the way.");

                    BottomPrompt();
                }
                else
                {
                    Clear();
                    ResetColor();
                    ForegroundColor = ConsoleColor.Blue;
                    WriteLine("You think about how good it would be to have a large stick.\nYou could've lived your dream as a pole vaulter. You have\nthis rock though. The time for justice has arrived.\nYou wind up your arm and throw it with incredible force.\nWith a BADUNK, the rock is subjugated to its fate. In\njust a few million years, long after you die, the rock\nwill have completely dissolved. That is if the river doesn't dry up.");

                    BottomPrompt();

                    WriteLine("By the size of the splash you can tell the water is shallow.\nIt appears that the river runs a long way and there is nothing\nthat you see that can help you cross. You decide to walk\nthrough the water. It's freezing. In a perfect example of\nthe endless, toxic cycle of revenge, the rock trips you once\nmore and you plunge into the water. You scramble out, now\ncompletly soaked.");
                    WriteLine("\nSitting there on the riverbank, you have an epiphany.\nYou learn revenge solves nothing. You fish the rock\nfrom the river and the two on you forge on with a new bond.");

                    BottomPrompt();
                }
                Clear();
                ResetColor();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("You made it across the river. For some reason you feel a sense of accomplshment.\nIn the grass you find another silver dollar.");
                player.money++;
                player.totalMoney++;
                WriteLine("To your left, you see another frogman sitting under a tarp. He is sitting on a\ntowel and an assortment of items are carefully laid out.");
                ReadLine();
                FirstTime2 = false;
            }
            WriteLine(phrog.Greeting);
            ReadLine();
            Clear();
            RunPhrogMenu();
        }

        public void location3()
        {
            if (FirstTime3 == true)
            {
                Clear();
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("The dark thicket leads to two pathways. One a misty and unsettling gravel path\nthat twist and turns(A), the other a pretty, overgrown path, lined by a\nmossy stone wall(B).\nPlease type A or B. ");
                input = ReadLine();

                input = input.ToLower();
                if (input == "a")
                {
                    ResetColor();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("You choose the creepy path. The fog is dense and musty smelling.\nNothing, but dead trees and grass. Somehow there is a florishing\nrosebush in all this death. A ray of white light shines on it.\nIt's so poeic. You pluck a rose for yourself and continue on.");
                    ReadLine();
                    Inventory.Add(rose.itemName);
                    rose.obtained = true;
                }
                else if (input == "b")
                {
                    ResetColor();
                    ForegroundColor = ConsoleColor.Green;
                    WriteLine("The path you chose is quite pleasant, but you notice a lot\nof junk laying on the ground. Wrappers and old popsickle\nsticks ruin the natural aesthetic. You want to clean it up,\nbut there's so much junk and you get overwhelmed.\nYou only manage to pick up a hunk of glass that was once\npart of a bottle. At least nobody will get hurt stepping\non it. You continue forward with a dim hope you'll find a garbage can.");
                    ReadLine();
                    Inventory.Add(glass.itemName);
                    glass.obtained = true;
                }
                else
                {
                    ResetColor();
                    ForegroundColor = ConsoleColor.Red;
                    WriteLine("Please choose a valid path.");
                    ResetColor();
                    ReadLine();
                    location3();
                }

                Clear();
                ResetColor();
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Just as you leave the pathway you spot a long, pale pair of legs\nstrolling around the forest by itself. The torso is rounded\nout and two black holes appear on the top, resembling eyes.\nNo doubt it is a Fresno Nightcrawler. A tall one. They're supposed\nto only stand 3 feet tall. Just like a Frogman, but this Nightcrawler\nis at least 3 times that size.");
                ReadLine();

                if (glass.obtained == true)
                {
                    WriteLine("This is what you came here for yet, you are too frightened to take a picture.\nMoonlight is coming through the leaves and you get an idea.\nYou take out the glass shard and use it to reflect light deeper in the woods.\nThe Nightcrawler sees it and runs over into the trees. It headbutts the tree.\nYou shine it to a different one. The Nightcrawler quickly runs over and\nhops in place. It looks like it's having fun. You decide to play with it more.\nYou shine the light on trees, rocks, and branches. Each time you\nmove the light the Nightcrawler almost instantly catches up and tries\nto interact with the light. After a few more minutes of this you can\ntell it's getting tired. but it doesn't want to stop. You put the shard\naway and the creature runs off. Suddenly you realize that you forgot to take a picture!");
                    ReadLine();
                }
                else
                {
                    WriteLine("There it is. The reason you came here. Something makes the pair\nof legs stop in its tracks. It turns in your direction.\nYour blood runs cold. You attempt to make a run for it, but it\nsprints in your direction and get in your face within the blink of an eye.\nYou two are face to face. Its massive eyes look at the rose in your hand.\nWith trembling hands you raise it. The creature doesn't move.\nYou raise it closer and press it against the creature. The rose\ngets absorbed into the white membrane. Little red circles\nform underneath its eyes. It's blushing? How adorable. The Nightcrawler\nhops up and down a few times before sprinting off into the woods.\nIf anything you at least made that creature’s day. Then you realize.\nYou forgot to take a picture!");
                    ReadLine();
                }

                WriteLine("Where the Nightcrawler was, you find some more money. It looks like you can actually see a clearing\nin the distance. You run over, hoping not to run into anymore Nightcrawlers.\nThis feels like an ordeal that is almost finally over. You'll be even closer\nto the radio tower.");
                player.money++;
                player.totalMoney++;
                ReadLine();

                FirstTime3 = false;
            }

            RunAreaMenu();

        }

        public void MonsterClearing()
        {
            Clear();
            ResetColor();
            ForegroundColor = ConsoleColor.Cyan;
            if (FirstTime4 == true)
            {
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("The gate opens to reveal a skeleton sitting on a crate and wearing a top hat.\nIt's mandible moves vertically on the otherwise motionless collection of bones.\n\"Camera...Can not enter.... with..... camera\". You realize that you never\ntook one picture in this strange place. You consider taking a picture of this\nfella at least but decide against it. Who knows the rage he just might unleash.");

                BottomPrompt();

                WriteLine("You enter the nearby clearing and are greeted with a stunning sight.\nA wide-open field with every single paranormal creature known in\nAmerican folklore and myth. Boo Hags, the Dover Demon, the\nEnfield Monster, Loveland Frogmen, Hodags, Snallygasters,\nThe Rougarou. Fresno Nightcrawlers, and so many more! They are all here!");

                BottomPrompt();

                WriteLine("You feel a nudge on your hip. You turn to find the artsy frogman.\n\"So you made it here, my guy. Do you still not know where you are?\"\n\"No.\"\nThe frog only smiled and pointed to the radio tower.\"That's your ticket\nout of here. I'll say this. You've been here before and you'll likely be here again.\" ");

                BottomPrompt();

                FirstTime4 = false;
            }

            WriteLine("You mingle with the crowd of monsters. They're all very friendly.\nYou chat it up with a few of them. It's so surreal. It's like this\nis a dream or something. You arrive at the radio tower. It's\nsurrounded by a chainlink fence.");

            BottomPrompt();

            if (towerKey.obtained == true)
            {
                WriteLine("You unlocked the door. A blue mist suddenly begins to poor from the entrance. Do you enter the door and leave the forest(A) or stay a little longer(B)?");
                input = ReadLine();

                if (input.ToLower() == "a")
                {
                    End = 1;
                    Ending();
                }
                else if (input.ToLower() == "b")
                {
                    RunAreaMenu();
                }
            }
        }

        public void Ending()
        {

            if(End == 1)
            {
                Clear();
                ForegroundColor = ConsoleColor.Cyan;
                WriteLine("Although you didn't get proof, you learned that mythical creatures do exist.\nYou vow to keep your goal to get hard evidence.");
                WriteLine("GOOD ENDING!\nYour resolve was bolstered by seeing the mythical creatures for yourself.\n:)");
            }
            else if(End == 2)
            {
                Clear();
                ForegroundColor = ConsoleColor.Blue;
                WriteLine("You walk through the door. Abandoning the promise that awaits in the forest.\nTime to get back to reality. Time to go home. Time to go back to her.");
                WriteLine("BAD ENDING!\nYou were influenced by the phrogs negativity and left the forest.\n:(");
            }
            else
            {
                Clear();
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine($"\"My name is {jose.NPCname} by the way.\" The frogman says to you.\n\"Funny. That's my friends name too.\" You say to him.");
                WriteLine("SECRET ENDING!\nYou found a family of Fresno Nightcrawlers and got hundreds of pictures for the public.\n:D");
            }
            WriteLine("Here is a list of the things you got along the way:");
            WriteLine($"Total Money Found: {player.totalMoney:c}");
            WriteLine($"Final Wallet Ammount: {player.money:c}");

            if (PwFind == true)
            {
                WriteLine("You found the hidden password! \'" + PWInput + "\'");
            }

            WriteLine("List of items collected: ");

            foreach (string Item in Inventory)
            {
                WriteLine(Item);
            }
            ResetColor();
            WriteLine("\n\nPress any key to exit...");
            ReadKey(true);
            Environment.Exit(0);
        }

        public string RanText()
        {
            string[] exploreText = { "You wander the area before the fence. You have the feeling that if you do this enough you might find something valuable. Right now, however, there is nothing important around.", "You wander the area before the fence. You have the feeling that if you do this enough you might find something valuable. Right now, however, there is nothing important around.", "You wander the area before the fence. a gust of wind picks up and a piece of paper flashes before your eyes. On it is the name SARAH. It gets away before you can catch it, but the name SARAH is one you would have a hard time forgetting. No doubt that the name holds a special significance." };

            return exploreText[GetRan(exploreText.Length)];
        }

        public int GetRan(int range)
        {
            Random random = new Random();
            return random.Next(range);
        }

        public void BottomPrompt()
        {
    
            WriteLine("\nPress any button...");
            ReadKey(true);
        }

    }
}