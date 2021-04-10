using System;
using System.Collections.Generic;
using System.Text;

namespace AdventGame
{
    class Items
    {
        public string itemName;
        
        public bool obtained;

        public Items(string lable, bool have)
        {
            itemName = lable;
            obtained = have;
        }
    }
}
