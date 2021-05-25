using System;
using MagicDestroyersClass.Armors.Cloth;
using MagicDestroyersClass.Weapons.Blunt;

namespace MagicDestroyersClass.Characters.SpellCasters
{
    public class Mage : SpellCaster
    {
        private ClothRobe bodyArmor;
        private Staff weapon;

        public ClothRobe BodyArmor
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

        public Mage(string name, int level, int healthPoints)
            : base(name,level,10)
        {
            base.HealthPoints = healthPoints;
            base.Faction = "SpellCasters";
            this.BodyArmor = new ClothRobe();
            this.Weapon = new Staff();
        }
        public Mage()
            : this("Bob",10)
        {
        }
        public Mage(string name, int abilityPoints)
            : this(name,1,50)
        {
        }
        public int ArcaneWrath()
        {
            return 10;
        }
        public int FireBall()
        {
            return 10;
        }
        public int Meditation()
        {
            return 5;
        }
        public override int Attack()
        {
            return this.ArcaneWrath();
        }
        public override int SpecialAttack()
        {
            return this.FireBall();
        }
        public override int Defend()
        {
            return this.Meditation();
        }
    }
}
