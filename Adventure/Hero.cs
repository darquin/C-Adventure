using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class Hero : Creature
    {
        public Hero()
            : base()
        {
            this.name = "Hero";
            this.lvl = 1;
        }
    }
}
