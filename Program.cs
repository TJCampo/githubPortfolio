using System;

namespace InsectGame
{
    class Program
    {
        static void Main(string[] args)
        {

            // Tyler Campo, Vinh Nguyen, Vinnie Konwent, AJ Warren.
            Beetle Philip = new Beetle();
            Philip.name = "Philip";
            Philip.age = 1;
            Philip.havehorn = true;
            Philip.havewings = true;
            Philip.numberoflegs = 6;
            Console.WriteLine($"Our beetles name is {Philip.name}.");
            Console.WriteLine($"{Philip.name} is {Philip.age} year old.");
            Console.WriteLine($"{Philip.name} has {Philip.numberoflegs} legs.");
            Philip.play();
            Philip.eat();
            GrassHopper Billy = new GrassHopper();
            Billy.name = "Billy";
            Billy.age = 1;
            Billy.havehorn = false;
            Billy.havewings = true;
            Billy.numberoflegs = 6;
            Console.WriteLine($"{Billy.name} is our grasshoppers name.");
            Console.WriteLine($"{Billy.name} is {Billy.age} month old.");
            Console.WriteLine($"{Billy.name} has {Billy.numberoflegs} legs.");
            Billy.play();
            Billy.eat();
        }
    }
}
