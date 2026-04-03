using HeroEngine.Core.UI;
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
        public Dictionary<string, AAbility>  Abilities { get; set; } = [];

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
        public void AddAbility(AAbility ability)
        {
            if (Abilities.ContainsKey(ability.Name))
            {
                Console.WriteLine(UIConfig.AbilityError.AbilityRepeated);
            }
            else
            {
                Abilities.Add(ability.Name, ability);
            }
        }
        public void UseAbility(AAbility ability)
        {
            Abilities[ability.Name].Execute(this);
        }
        public void ShowAbilities()
        {
            var sortedList = Abilities.Values.OrderByDescending(num => num.Rarity).ToList();

            foreach(var ability in sortedList)
            {
                Console.WriteLine($"[{ability.Rarity}] {ability.Name} | Type: {ability.Type} | Cost: {ability.Cost}");
            }
        }
    }
}
