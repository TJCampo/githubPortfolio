using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace AdventGame
{
    class MerchantPhrog : NPCs
    {
      public void temptation()
        {
            ForegroundColor = ConsoleColor.Blue;
            WriteLine("\n\n\"If you want my advice. I think you should quit this silly dream and come back to reality. You have better things to do and people at home who miss you. They won't wait forever you know.\"");
            ReadLine();
            WriteLine("A door manifest next to him. A blue mist emanates from it.");
            ReadLine();
            WriteLine("\"You want my advice? Go through this door and go home,\" The phrog says grimly.");
            Console.ResetColor();
        }
    }
}
        
     
    
