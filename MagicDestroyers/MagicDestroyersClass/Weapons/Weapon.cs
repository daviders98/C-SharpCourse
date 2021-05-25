using System;
namespace MagicDestroyersClass.Weapons
{
    public abstract class Weapon
    {
        private int damage;

        public int Damage
        {
            get
            {
                return this.damage;
            }
            set
            {
                if (value > 0)
                {
                    this.damage = value;
                }
                else
                {
                    this.damage = 10;
                }
            }
        }

    }
}
