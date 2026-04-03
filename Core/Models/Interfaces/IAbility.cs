using HeroEngine.Core.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models.Interfaces
{
    public interface IAbility
    {
        string Name { get; }
        ERarities Rarity { get; }
        EAbilityType Type { get; }
        int Cost { get; }
        void Execute(AHero hero);
    }
}
