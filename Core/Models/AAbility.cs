using HeroEngine.Core.Models.Enums;
using HeroEngine.Core.Models.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public abstract class AAbility : IAbility
    {
        public string Name { get; }

        public ERarities Rarity { get; }

        public EAbilityType Type { get; }

        public int Cost { get; }
        public AAbility(string name, ERarities rarity, EAbilityType type, int cost)
        {
            Name = name;
            Rarity = rarity;
            Type = type;
            Cost = cost + (int) rarity;
        }

        public abstract void Execute(AHero hero);
        public override string ToString()
        {
            return $"[{Rarity}] {Name} | Type: {Type} | Cost: {Cost}";
        }
    }
}
