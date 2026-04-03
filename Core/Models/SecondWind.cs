using HeroEngine.Core.Models.Enums;
using HeroEngine.Core.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public class SecondWind: AAbility
    {
        private int _heal = 30;
        public SecondWind() : base("Second Wind", RandomRarityHelper.GetRandomRarity(), EAbilityType.Attack, 10)
        {
        }
        public override void Execute(AHero hero)
        {
            int newHeal = _heal + (int)Rarity;
            Console.WriteLine(UIConfig.Abilities.SecondWind, hero.Name, newHeal);
        }
    }
}
