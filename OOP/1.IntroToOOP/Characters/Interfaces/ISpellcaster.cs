using System;
using _1.IntroToOOP.Weapons;

namespace _1.IntroToOOP.Characters.Interfaces
{
    public interface ISpellcaster
    {
        int ManaPoints { get; set; }
        Staff Weapon { get; set; }

        void CastSpell(Character character);
    }
}
