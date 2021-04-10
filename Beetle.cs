using System;
using System.Collections.Generic;
using System.Text;

namespace InsectGame
{
    class Beetle
    {
        public string name;
        public int age;
        public int numberoflegs;
        public bool havehorn;
        public bool havewings;


        public void eat()
        {
            Console.WriteLine($"{name} is eating.");
        }
        public void play()
        {
            Console.WriteLine($"{name} is playing.");
        }

            
    }
}
