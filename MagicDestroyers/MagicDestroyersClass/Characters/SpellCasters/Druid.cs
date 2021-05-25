using System;
using MagicDestroyersClass.Armors.Leather;
using MagicDestroyersClass.Weapons.Blunt;

namespace MagicDestroyersClass.Characters.SpellCasters
{
    public class Druid : SpellCaster
    {
        private LeatherVest bodyArmor;
        private Staff weapon;
        
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
        public Staff Weapon
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

        public Druid(string name,int level, int healthPoints)
            : base(name, level, 10)
        {
            base.HealthPoints = healthPoints;
            base.Faction = "SpellCasters";
            this.BodyArmor = new LeatherVest();
            this.Weapon = new Staff();
        }
        public Druid()
            : this("Bob", 10)
        {
        }
        public Druid(string name, int abilityPoints)
            : this(name,1,50)
        {
        }
        public void MoonFire()
        {
            throw new NotImplementedException();
        }
        public void Starburst()
        {
            throw new NotImplementedException();
        }
        public void OneWithNature()
        {
            throw new NotImplementedException();
        }
    }
}
