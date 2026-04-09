using HeroEngine.Core.Models;
using HeroEngine.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.UI
{
    public static class RandomNumsHelper
    {
        private static Random Rnd = new Random();

        public static ERarities GetRandomRarity()
        {
              int MinimumRarity = 1, MaximumRarity = 5, randomNum = Rnd.Next(MinimumRarity, MaximumRarity);

            switch (randomNum)
            {
                case 1:
                    return ERarities.Common;
                case 2:
                    return ERarities.Rare;
                case 3:
                    return ERarities.Epic;
                case 4:
                    return ERarities.Legendary;
                default:
                    return ERarities.Common;
            }
        }
        public static int GetRandomDamage()
        {
            int minDamage = 1, maxDamage = 21, damage = Rnd.Next(minDamage, maxDamage);
            return damage;
        }
        public static int GetRandomHero(List<AHero> party)
        {
            int minHeroVal = 0, choosenHero = Rnd.Next(minHeroVal, party.Count);
            return choosenHero;
        }
    }
}
