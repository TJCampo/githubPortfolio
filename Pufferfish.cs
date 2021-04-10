using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreaturesOfTheSeaGUI
{
    class Pufferfish : Fish
    {
        public override string Eat(Item item)
        {
            //Checking the type 
            if (item is Food)
            {

                if (HungerLevel < 100)
                {
                    HungerLevel += 50;
                    return $"{Name} is eating {item.Name}  - {HungerLevel}";
                }
                else
                {
                    return $"{Name} is not hungry anymore";
                }

            }
            else
            {
                return $"Sorry {Name} only eats algae. {item.Name} is not algae";
            }

        }
    }
}
