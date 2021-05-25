using System;
using MagicDestroyersClass.Armors.Leather;
using MagicDestroyersClass.Weapons.Blunt;

namespace MagicDestroyersClass.Characters.Melee
{
    public class Knight : Melee
    {
        private LeatherVest bodyArmor;
        private Hammer weapon;

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
        public Hammer Weapon
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

        public Knight(string name, int level,int healthPoints)
            :base(name,level,10)
        {
            base.HealthPoints = healthPoints;
            base.Faction = "Melee";
            this.BodyArmor = new LeatherVest();
            this.Weapon = new Hammer();
        }
        public Knight()
            : this("Bob", 10)
        {
        }
        public Knight(string name, int abilityPoints)
            : this(name, 10, 50)
        {
        }
        public void HolyBlow()
        {
            throw new NotImplementedException();
        }
        public void PurifySoul()
        {
            throw new NotImplementedException();
        }
        public void RighteousWings()
        {
            throw new NotImplementedException();
        }
    }
}
