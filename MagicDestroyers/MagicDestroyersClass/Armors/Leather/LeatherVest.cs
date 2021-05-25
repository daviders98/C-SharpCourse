using System;
namespace MagicDestroyersClass.Armors.Leather
{
    public class LeatherVest
    {
        private int armorPoints;

        public LeatherVest()
        {
            this.ArmorPoints = 10;
        }
        public int ArmorPoints
        {
            get
            {
                return this.armorPoints;
            }
            set
            {
                if (value > 0)
                {
                    this.armorPoints = value;
                }
                else
                {
                    this.armorPoints = 1;
                }
            }
        }
    }
}
