using System;
using _1.IntroToOOP.Characters.Interfaces;
using _1.IntroToOOP.Enumerations;
using _1.IntroToOOP.Weapons;
using IntroToOOP.Weapons.Sharp;

namespace _1.IntroToOOP.Characters
{
    public class Mage:Character,IDoMath,ISpellcaster
    {
        private readonly int id;
        private const int DEFAULT_DAMAGE = 10;
        private readonly Staff DEFAULT_WEAPON = new Staff();
        public Mage(int damage)
            : base(damage)
        {

        }

        public Mage()
            : this("Bob")
        {

        }
        public Mage(string name)
            : this(DEFAULT_DAMAGE, 100, name, Faction.GoodGuy)
        {
        }
        public Mage(int dmg, int hlt, string nm, Faction faction)
        {
            base.Damage = dmg;
            base.HealthPoints = hlt;
            base.Name = nm;
            this.Weapon = DEFAULT_WEAPON;
            this.id++;
            if (faction == Faction.GoodGuy)
            {
                base.Level = 3;
            }
            else
            {
                base.Level = 1;
            }
        }
        public void Greetings(string name)
        {
            Console.WriteLine($"{base.Name} greets {name}");
        }
        public void Attack(Mage enemy)
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
        public int ManaPoints { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        
        public override void AddTwoNumbers()
        {
            int sum = base.NumberA + base.NumberB + 123;
            sum -= 123;
            Console.WriteLine(sum);
        }

        public void CastSpell()
        {
            throw new NotImplementedException();
        }
    }
}
