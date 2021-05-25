using System;
namespace IntroToOOP.Weapons.Sharp
{
    public class Sword
    {
        private int damage;

        public int  Damage {
            get
            {
                return this.damage;
            }
            set
            {
                if (value >=1 && value <=10)
                {
                    this.damage = value;
                }
                else
                {
                    this.damage = 1;
                    Console.WriteLine("Innapropiate value. Damage should be from 1 to 10") ;
                }
            }
        }

        public Sword()
        {
            this.Damage = 10;
        }
        public void BloodThirst()
        {
            throw new NotImplementedException();
        }
    }
}
