using System;
using System.Threading;
using _1.IntroToOOP.Characters.Interfaces;
using _1.IntroToOOP.Enumerations;
using IntroToOOP.Weapons.Sharp;

namespace _1.IntroToOOP.Characters
{
    public abstract class Character : IDoMath
    {
        private const int DEFAULT_DAMAGE = 10;
        private const int DEFAULT_HEALTHPOINTS = 50;
        private const string DEFAULT_NAME = "Bob";
        private Faction faction;
        public Faction Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == Faction.GoodGuy || value == Faction.BadGuy)
                {
                    faction = value;
                }
            }
        }
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private int damage;
        private int healthPoints;
        private string name;
        private int level;
        private Sword weapon;
        public int Level
        {
            get
            {
                return level;
            }
            set
            {
                if (value >= 1 && value <= 100)
                {
                    level = value;
                }
                else
                {

                    throw new ArgumentOutOfRangeException(string.Empty, "Innapropiate lvl, this must be between 0 and 100");
                }
            }
        }

        public int Damage
        {
            get
            {

                return damage;
            }
            set
            {
                damage = value;
            }
        }
        public virtual int HealthPoints {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value >=0 && value <=100)
                {
                    this.healthPoints = value;
                }
            }
        }

        public string Name { get; set; }
        public Sword Weapon { get => this.weapon; set => this.weapon = value; }
        private int numberA;
        private int numberB;
        public int NumberA { get => this.numberA; set => this.numberA = value; }
        public int NumberB { get => this.numberB; set => this.numberB = value; }
        //IF U HAVE MULTIPLE CONSTRUCTORS ON A DERIVED CLASS OF THIS CLASS..

        //U MUST HAVE A PARAMETER-LESS CONSTRUCTOR IN THE BASE CLASS
        public Character(int damage)
        {
            this.Damage = damage;
            this.HealthPoints = DEFAULT_HEALTHPOINTS;
            this.Name = DEFAULT_NAME;
            this.Weapon = new Sword();
            if (faction == Faction.GoodGuy)
            {
                this.Level = 3;
            }
            else
            {
                this.Level = 1;
            }
        }
        protected Character()
        {

        }
        //implementation of a father method overwriten
        //when using this class u do this method.
        //when using the variables, the virtual makes it so that its different for each child class
        public virtual void Move(double speed)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("I am moving.");
                Thread.Sleep((int)speed);
            }
        }
        //empty and derived classes will implement it.
        //if empty use abstract, can't have implementation.
        //just like interfaces.
        public abstract void AddTwoNumbers();
    }
}
