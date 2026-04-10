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
        public string Name { get; set; }

        public AHero(string name, int hp, int level) : base(hp)
        {
            Level = level;
            MaxHp += level;
            Hp += level;
            Name = name;
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
        protected override void CantAttack()
        {
            Console.WriteLine($"{Name} can't attack because they're dead");
        }
        protected override void CantGetAttacked()
        {
            Console.WriteLine($"{Name} can't get attacked because they're dead");
        }
        public override void GetAttacked(int damage)
        {
            if (Hp < 0)
            {
                CantGetAttacked();
            }
            else
            {
                Console.WriteLine($"{Name} gets attacked. Loses {damage} hp");
                Hp -= damage;
            }
        }
    }
}
