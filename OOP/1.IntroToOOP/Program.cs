using System;
using System.Collections.Generic;
using _1.IntroToOOP.Characters;
using _1.IntroToOOP.Characters.Interfaces;
using _1.IntroToOOP.Enumerations;
using IntroToOOP.Characters.Melee;

//STATIC CLASSES CANNOT BE INSTANTIATED
//public is an access modifier.
//Fields, properties, constructors and methods.
namespace IntroToOOP
{
    public class Program
    {
        static void Main()
        {
            double suma = 0;
            for (var i = 0; suma <= 5; i++)
            {
                suma += .25;
            }
        }

    }
}
