using System;
namespace MagicDestroyersClass.Characters.SpellCasters
{
    public abstract class SpellCaster : Character
    {
        private int manaPoints;
        public int ManaPoints
        {
            get
            {
                return this.manaPoints;
            }
            set
            {
                if (value > 0)
                {
                    this.manaPoints = value;
                }
                else
                {
                    this.manaPoints = 1;
                }
            }
        }
        public SpellCaster(string name, int level,int manaPoints)
            : base(name, level)
        {
            base.Name = name;
            base.Level = level;
            this.ManaPoints = manaPoints;
        }
    }
}
