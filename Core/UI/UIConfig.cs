using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.UI
{
    public static class UIConfig
    {
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
    }
}
