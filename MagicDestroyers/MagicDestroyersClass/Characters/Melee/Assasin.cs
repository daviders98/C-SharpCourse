using System;
using MagicDestroyersClass.Armors.Leather;
using MagicDestroyersClass.Weapons.Sharp;

namespace MagicDestroyersClass.Characters.Melee
{
    public class Assasin : Melee
    {
        private LeatherVest bodyArmor;
        private Sword weapon;
        
        public LeatherVest BodyArmor
        {
            get
            {
                return this.bodyArmor;
            }
            set
            {
                this.bodyArmor = value;
            }
        }
        public Sword Weapon
        {
            get
            {
                return this.weapon;
            }
            set
            {
                this.weapon = value;
            }
        }

        public Assasin(string name,int level,int healthPoints)
            : base(name,level,10)
        {
            base.HealthPoints = healthPoints;
            base.Faction = "Melee";
            this.BodyArmor = new LeatherVest();
            this.Weapon = new Sword();
        }
        public Assasin()
            :this("Bob",10)
        {
        }
        public Assasin(string name, int abilityPoints)
            :this(name,1,50)
        {
        }
        public void Raze()
        {
            throw new NotImplementedException();
        }
        public void Bleed()
        {
            throw new NotImplementedException();
        }
        public void Survival()
        {
            throw new NotImplementedException();
        }
    }
}
