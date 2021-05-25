using System;
using System.Collections.Generic;
using MagicDestroyersClass.Characters;
using MagicDestroyersClass.Characters.Melee;
using MagicDestroyersClass.Characters.SpellCasters;

namespace MagicDestroyersClass
{
    class Program
    {
        static void Main()
        {
            bool gameOver = false;
            List<Character> characters = new List<Character>
            {
                //Declare it like this to save space of unnecesary variables.
                new Warrior(),
                //new Knight(),
                //new Assasin(),
                //new Druid(),
                new Mage(),
                //new Necromancer()
                new Warrior(),
                new Mage(),
                new Mage()
            };

            List<Melee> meleeTeam = new List<Melee>();
            List<SpellCaster> spellTeam = new List<SpellCaster>();

            foreach (var charactr in characters)
            {
                if (charactr is Melee)
                {
                    meleeTeam.Add((Melee)charactr);
                }
                else
                {
                    spellTeam.Add((SpellCaster)charactr);
                }
            }

            //THROUGH ABSTRACT METHODS u can get specific methods of derived classes.
            //a class for each object
            //cohesion 1 class has a purpose.

            //Coupling as low relations as posible.
            //Coupling has the advantage that when there's an error, u only need to fix the class involed, when multiple
            //classes are involved, then u need to fix more things.
            while (!gameOver)
            {
                //1. Take a random melee
                //2. Take a random spellcaster
                spellTeam[0].TakeDamage(meleeTeam[0].Attack(), meleeTeam[0].Name);
                //3. Melee attacks spellcaster
                //3.1 Check if the character died and if so, remove it from team
                //3.2 if dead, get another character for the team
                meleeTeam[0].TakeDamage(spellTeam[0].Attack(), meleeTeam[0].Name);
                //4. Spellcaster attacks Melee
                //4.1 Check if the character died and if so, remove it from team 
                //4.2 if dead, get another character for the team

                //5. If everyone from a team is dead, gameover = true

            }

        }
    }
}