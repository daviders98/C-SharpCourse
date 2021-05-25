using System;
using MagicDestroyersClass.Armors.Mail;
using MagicDestroyersClass.Weapons.Sharp;

namespace MagicDestroyersClass.Characters.Melee
{
    public class Warrior : Melee
    {
        private ChainLink bodyArmor;
        private Axe weapon;
        public ChainLink BodyArmor
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
        public Axe Weapon
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

        public Warrior(string name, int level, int healthPoints)
            //Deriving from the Melee class, this is needed to produce a warrior.
            : base(name,level,10)
        {
            base.HealthPoints = healthPoints;
            base.Faction = "Melee";
            this.BodyArmor = new ChainLink();
            this.Weapon = new Axe();
        }
        public Warrior()
            : this("Bob", 10)
        {
        }
        public Warrior(string name, int abilityPoints)
            : this(name, 1, 50)
        {
        }
        public int Strike()
        {
            return 10;
        }
        public int Execute()
        {
            throw new NotImplementedException();
        }
        public int SkinHarden()
        {
            return 5;
        }
        public override int Attack()
        {
            return this.Strike();
        }
        public override int SpecialAttack()
        {
            return this.Execute();
        }
        public override int Defend()
        {
            return this.SkinHarden();
        }
    }
}
