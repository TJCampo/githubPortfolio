using System;

/* MOONLIGHT DRIVE (Adventure Game Project)
 * Tyler Campo
 * 2/5/21 - 3/30/21
 *  This work is a derivative of 
 * "C# Adventure Game" by http://programmingisfun.com, used under CC BY.
 * https://creativecommons.org/licenses/by/4.0/
 * Ascii text http://patorjk.com/software/taag/#p=display&f=Graffiti&t=Type%20Something%20
 * Menu help https://canvas.colum.edu/courses/21700/pages/keyboard-controlled-menu-incl-video?module_item_id=1052564
 */

namespace AdventGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Adventure Game: Moonlit Pilgrimage";
            Game game = new Game();
            game.run();
        }
            

    }
};
