using System;
namespace MagicDestroyersClass.Characters.Melee
{
    public abstract class Melee : Character
    {
        private int abilityPoints;
        public int AbilityPoints
        {
            get
            {
                return this.abilityPoints;
            }
            set
            {
                if (value > 0)
                {
                    this.abilityPoints = value;
                }
                else
                {
                    this.abilityPoints = 1;
                }
            }
        }
        public Melee(string name, int level, int abilityPoints)
            :base(name,level)
        {
            base.Name = name;
            base.Level = level;
            this.AbilityPoints = abilityPoints;
        }
    }
}
