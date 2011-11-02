using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class Villain : Creature
    {
        private static Creature player;
        private string alignment;
        private int sightRadius = 5;
        protected Creature target;

        public Villain()
            : base()
        {
            this.alignment = "Evil";
            this.name = "Monster";
        }
    }
}
