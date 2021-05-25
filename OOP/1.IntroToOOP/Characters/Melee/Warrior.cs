using System;
using _1.IntroToOOP.Characters;
using _1.IntroToOOP.Characters.Interfaces;
using _1.IntroToOOP.Enumerations;
using IntroToOOP.Weapons.Sharp;

namespace IntroToOOP.Characters.Melee
{
    public class Warrior : Character , IDoMath
    {
        //ACCESS MODIFIER.. private fields, properties public.
        //THESE ARE FIELDS
        //private by default
        //internal is used to protect things within a project, even if u have a reference
        //the variables inside of the class, cannot be accesed if it is internal.

        //protected is used to protect variables within families of classes (inheritance)
        //protected internal will be available to everything within the project and other clases familiars of the class.

        //protected and protected internal cannot be when declaring a class
        //THIS IS CONSTANT, AND IT CAN BE ASSIGNED DURING RUNTIME

        //Const is assigned in the code and not in runtime.
        private const int DEFAULT_DAMAGE = 10;
        //when u want a constant class, u use readonly

        //STATIC METHODS. methods of a class, the console.writeline is one of them
        //u can get default values of a class or things that the class has by itself and not the instances.
        private readonly Sword DEFAULT_WEAPON = new Sword();
        private readonly int id;
        //property.
        //middle man that decides whether to assign it or not.
        public Warrior(int damage)
            :base(damage)
        {

        }

        public Warrior()
            : this("Bob")
        {
            
        }
        //constructor.
        //initializes values of a class
        public Warrior(string name)
            :this(DEFAULT_DAMAGE,100,name, Faction.GoodGuy)
        {
        }
        public Warrior(int dmg, int hlt, string nm, Faction faction)
        {
            base.Damage = dmg;
            base.HealthPoints = hlt;
            base.Name = nm;
            base.Weapon = new Sword();
            this.id++;
            if (faction==Faction.GoodGuy)
            {
                base.Level = 3;
            }
            else
            {
                base.Level = 1;
            }
        }


        //methods do not require the static thing.
        public void Greetings(string name)
        {
            //the warrior greets the other character.
            //conflicting names...
            //PROPERTIES, FIELDS AND 
            Console.WriteLine($"{base.Name} greets {name}");
        }
        public void Attack(Warrior enemy)
        {
            enemy.HealthPoints -= Damage;
            Console.WriteLine($"{base.Name} is attacking {enemy.Name}. {enemy.Name} now has {enemy.HealthPoints} health points remaining");
        }

        public void Strike()
        {
            throw new NotImplementedException();
        }
        public static void getInfo()
        {
            Console.WriteLine(DEFAULT_DAMAGE);
        }

        public override void Move(double speed)
        {
            speed *= 1.2;
            base.Move(speed);
        }

        public override void AddTwoNumbers()
        {
            Console.WriteLine(base.NumberA+base.NumberB);
        }

        public override int HealthPoints {
            get
            {
                return base.HealthPoints;
            }
            set
            {
                if (value >=0 && value <=120)
                {
                    base.HealthPoints = value;
                }
            }
                
        }
    }

}