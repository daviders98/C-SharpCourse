using System;
using MagicDestroyersClass.Armors.Leather;
using MagicDestroyersClass.Weapons.Sharp;

namespace MagicDestroyersClass.Characters.SpellCasters
{
    public class Necromancer : SpellCaster
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

        public Necromancer(string name, int level, int healthPoints)
            : base(name,level,10)
        {
            base.HealthPoints = healthPoints;
            base.Faction = "SpellCasters";
            this.BodyArmor = new LeatherVest();
            this.Weapon = new Sword();
        }
        public Necromancer()
            : this("Bob",10)
        {
        }
        public Necromancer(string name, int abilityPoints)
            :this(name,1,50)
        {
        }
        public void ShadowRage()
        {
            throw new NotImplementedException();
        }
        public void VampireTouch()
        {
            throw new NotImplementedException();
        }
        public void BoneShield()
        {
            throw new NotImplementedException();
        }

    }
}
