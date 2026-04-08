using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public class Warrior: AHero
    {
        public int Armor { get; set; }
        public string WarScream { get; set; }
        public Warrior(string name, int level, int armor, string warScream) : base(name, level)
        {
            Armor = armor + level;
            MaxHp += level;
            Hp += level;
            WarScream = warScream;
        }
        public override string ToString()
        {
            return base.ToString() + $" | Armor: {Armor}";

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
                return damage * 3;
            }
        }

        public override void GetAttacked(int damage)
        {
            if (Hp <= 0)
            {
                CantGetAttacked();
            }
            else
            {
                int reducedDamage = (damage - Armor < 0) ? 0 : damage - Armor;
                Console.WriteLine($"{Name} gets attacked. Loses {reducedDamage} hp");
                Hp -= reducedDamage;
            }
        }
    }
}
