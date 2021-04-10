using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreaturesOfTheSeaGUI
{
    public class Creature
    {

        public string Name { get; set; }

        public string Color { get; set; }

        public int Age { get; set; }


        public int HungerLevel { get; set; } = 0;


        public ProgressBar HungerLevelProgress { get; set; } 


        public System.IO.UnmanagedMemoryStream CreatureSound = CreaturesOfTheSeaGUI.Resource.TurtleSound;

        public Creature()
        {
            
        }

        public Creature(string name, int age, string color)
        {
            Name = name;
            Age = age;
            Color = color;
        }

        public virtual string Eat()
        {
            return $"{Name} Creature EAT";
            //Console.WriteLine($"{Name} Creature EAT");
        }

        public virtual string Eat(Item item)
        {
            //Console.WriteLine();
            return $"{Name} Creature EAT";
        }

        public string Communicate()
        {

            CreatureSound.Position = 0;
            using (System.Media.SoundPlayer sound = new System.Media.SoundPlayer(CreatureSound))
            {
                sound.Play();
            }

            return $"{Name} says hi";

        }

    }
}
