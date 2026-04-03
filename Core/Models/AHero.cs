using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public abstract class AHero
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int MaxHp { get; set; } = 100;
        public int Hp
        {
            get => _hp;
            set => _hp = (value < 0) ? 0 : value;
        }
        private int _hp = 100;

        public AHero(string name, int level)
        {
            Name = name;
            Level = level;
        }
        public abstract int Attack(int damage);
        public abstract void GetAttacked(int damage);
        protected void CantAttack()
        {
            Console.WriteLine($"{Name} can't attack because they're dead");
        }
        protected void CantGetAttacked()
        {
            Console.WriteLine($"{Name} can't get attacked because they're dead");
        }
    }
}
