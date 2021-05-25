using System;
namespace MagicDestroyersClass.Armors.Mail
{
    public class ChainLink
    {
        private int armorPoints;

        public ChainLink()
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
