using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adventure
{
    class Creature
    {
        protected string name;
        /// <summary> Different variables for the stats
        /// <para>
        /// <c>int str</c> for strength, <c>int end</c> for endurance, <c>int agi</c> for agility. These are used to determine
        /// values for the skills
        /// </para>
        /// </summary>
        /// 
        protected int str;
        protected int end;
        protected int agi;

        /// Variables for skills
        /// attack = 10 + str
        /// defence = agi/2
        /// maxHealth = end * 2 (current health = how much health the creature has left
        /// skill = critical hit chance
        /// 

        protected int attack;
        protected int defence;
        protected int maxHealth;
        protected int currentHealth;
        protected int skill;
        protected int currentExp;
        protected double expToLvl;
        protected int lvl;

        ///Variables for fighting
        ///

        private int dealtDamage;
        private int criticalChance;
        private Random randomGen = new Random();

        public Creature()
        { 
        }

        public String getName()
        {
            return this.name;
        }
        public void setName(String param_Name)
        {
            this.name = param_Name;
        }

        ///Stat handling
        public void setAttack()
        {
            this.attack = 10 + this.str;
        }
        public int getAttack()
        {
            return this.attack;
        }
        public void setDefence()
        {
            this.defence = this.agi / 2;
        }
        public int getDefence()
        {
            return this.defence;
        }
        public void setMaxHealth()
        {
            this.maxHealth = this.end * 2;
            this.currentHealth = this.maxHealth;
        }
        public int getCurrentHealth()
        {
            return this.currentHealth;
        }
        public void setSkill()
        {
            this.skill = (this.str + this.agi + this.end) / 3;
        }
        public int getSkill()
        {
            return this.skill;
        }
        /// End stat handling

    }
}
