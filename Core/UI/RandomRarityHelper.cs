using HeroEngine.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.UI
{
    public static class RandomRarityHelper
    {
        private static Random Rnd = new Random();
        private static int MinimumRarity = 1;
        private static int MaximumRarity = 5;

        public static ERarities GetRandomRarity()
        {
            int randomNum = Rnd.Next(MinimumRarity, MaximumRarity);

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
    }
}
