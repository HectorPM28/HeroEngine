using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public class Mage: AHero
    {       
        public int MaxMana { get; set; }
        public int Mana { get; set; }
        public int ArcaneLevel { get; set; }

        public Mage (string name, int level, int mana, int arcaneLevel): base(name, level)
        {
            MaxMana = mana + level;
            MaxHp += level;
            Hp += level;
            Mana = mana + level;
            ArcaneLevel = arcaneLevel;
        }
        public override string ToString()
        {
            return $"[{this.GetType().Name}] {Name} | Level: {Level} | HP: {Hp}/{MaxHp} | Mana: {Mana}/{MaxMana}";

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
                return damage * 2;
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
