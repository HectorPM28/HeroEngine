using HeroEngine.Core.UI;
using System;
using System.Collections.Generic;
using System.Text;
using static HeroEngine.Core.UI.UIConfig;

namespace HeroEngine.Core.Models
{
    public abstract class AHero: AEntity
    {
        public int Level { get; set; }

        public AHero(string name, int hp, int level) : base(name, hp)
        {
            Level = level;
            MaxHp += level;
            Hp += level;
        }
        public override string ToString()
        {
            return $"[{this.GetType().Name}] {Name} | Level: {Level} | HP: {Hp}/{MaxHp}";
        }
        public virtual void AddAbility(AAbility ability)
        {
            Console.WriteLine($"{Name} cannot learn abilities.");
            Thread.Sleep(1000);
        }
    }
}
