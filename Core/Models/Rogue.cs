using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public class Rogue : AHero
    {
        public int HiddenDagger { get; set; }
        private int Multiplier = 2;
        public Rogue(string name, int level, int hiddenDagger) : base(name, level)
        {
            MaxHp += level;
            Hp += level;
            HiddenDagger = hiddenDagger;
        }
        public override string ToString()
        {
            return base.ToString() + $" | Multiplier: {Multiplier}";

        }
        public override int Attack(int damage)
        {
            if (Hp < 0)
            {
                CantAttack();
                return 0;
            }
            else
            {
                return damage * Multiplier;
            }
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
