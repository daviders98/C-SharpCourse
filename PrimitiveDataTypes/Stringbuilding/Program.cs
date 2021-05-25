using System;

class Program
{
    static void Main()
    {
        string nameOfCharacter = "Tod";
        string spellName = "Fireball";
        int damage = 100;

        //FORMAT WITH PLACEHOLDERS. SAME RESULT, LESS CONCATENATION.
        string damageReport = "The " + nameOfCharacter + " character took " + damage + " damage from " + spellName;
        Console.WriteLine(damageReport);
        string damageReportV2 = string.Format("The {0} character took {1} damage from {2}",nameOfCharacter,damage,spellName);
        Console.WriteLine(damageReportV2);
        string damageReportV21 = string.Format("The {0} character took {1} damage from {2} and the character {0} is now dead", nameOfCharacter, damage, spellName);
        Console.WriteLine(damageReportV21);

        //INTERPOLATION
        string damageReportv3 = $"The {nameOfCharacter} character took {damage} damage from {spellName}";
        Console.WriteLine(damageReportv3);
    }
}