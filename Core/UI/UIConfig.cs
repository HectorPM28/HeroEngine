using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.UI
{
    public static class UIConfig
    {
        public static void ShowHeroes()
        {
            Console.WriteLine("1. Warrior\n2. Mage\n3. Rogue");
            Console.WriteLine("Select hero");
        }
        public static void ShowMenu()
        {
            Console.WriteLine("What do you wanna do?");
            Console.WriteLine("1. See party");
            Console.WriteLine("2. Assign abilities");
            Console.WriteLine("3. Fight enemies");
            Console.WriteLine("4. Finish adventure");
        }
        public static void ShowAbilities()
        {
            Console.WriteLine("1. Thunder Smash");
            Console.WriteLine("2. Secon Wind");
            Console.WriteLine("3. Iron Fortress");
            Console.WriteLine("4. War Taunt");
            Console.WriteLine("Select an ability");
        }
        public static class Abilities
        {
            public const string ThunderSmash = "{0} channels the storm! {1} lightning damage to all enemies!";
            public const string IronFortress = "{0} builds a wall to help their commrades. +{1} to all heroes";
            public const string SecondWind = "{0} guides the wind. The party heals {1} hp.";
            public const string WarTaunt = "{0} screams at the enemies. The next hit is stronger!";
        }
        public static class AbilityError
        {
            public const string AbilityRepeated = "This hero already has this ability";
        }
        public static class InputError
        {
            public const string IntError = "Insert a number!";
        }
    }
}
