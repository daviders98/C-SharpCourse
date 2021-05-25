using System;
namespace MagicDestroyersClass.Armors.Cloth
{
    public class ClothRobe
    {
        private int armorPoints;

        public ClothRobe()
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
