using System;
using MagicDestroyersClass.Characters.Interfaces;

namespace MagicDestroyersClass.Characters
{
    //ABSTRACT CANT BE INSTANTIATED.
    public abstract class Character : IAttack, IDefend
    {
        private string name;
        private string faction;

        private bool isAlive;
        private int scores;
        private int healthPoints;
        private int level;
        public int Scores
        {
            get
            {
                return this.scores;
            }
            private set
            {
                this.scores = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value.Length >= 2 && value.Length <= 10)
                {
                    this.name = value;
                }
                else
                {
                    this.name = "Bob";
                }
            }
        }
        public bool IsAlive
        {
            get
            {
                return this.isAlive;
            }
            private set
            {
                this.isAlive = value;
            }
        }
        public string Faction
        {
            get
            {
                return this.faction;
            }
            set
            {
                if (value == "Melee")
                {
                    this.faction = value;
                }
                else
                {
                    this.faction = "Melee";
                }
            }
        }
        
        public int HealthPoints
        {
            get
            {
                return this.healthPoints;
            }
            set
            {
                if (value > 0)
                {
                    this.healthPoints = value;
                }
                else
                {
                    this.healthPoints = 50;
                }
            }
        }
        public int Level
        {
            get
            {
                return this.level;
            }
            set
            {
                if (value > 0)
                {
                    this.level = value;
                }
                else
                {
                    this.level = 1;
                }
            }
        }

        public Character(string name, int level)
        {
            this.Name = name;
            this.Level = level;
        }

        public virtual int Attack()
        {
            throw new NotImplementedException();
        }

        public virtual int SpecialAttack()
        {
            throw new NotImplementedException();
        }

        public virtual int Defend()
        {
            throw new NotImplementedException();
        }
        public void TakeDamage(int damage,string attackerName)
        {
            if (this.Defend() < damage)
            {
                this.HealthPoints = this.HealthPoints - damage + this.Defend();
                if (this.HealthPoints <=0)
                {
                    this.isAlive = false;
                }
            }
            if (!this.isAlive)
            {
                Console.WriteLine($"{this.name} received {damage} from {attackerName} and is dead");
            }
            else
            {
                Console.WriteLine($"{this.name} received {damage} from {attackerName}.");
            }
        }
    }
}
