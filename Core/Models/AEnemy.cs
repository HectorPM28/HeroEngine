using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public abstract class AEnemy: AEntity
    {
        protected AEnemy(int hp) : base(hp)
        {
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] HP: {Hp}/{MaxHp}";
        }
        public override void GetAttacked(int damage)
        {
            if (Hp <= 0)
            {
                CantGetAttacked();
            }
            else
            {
                Console.WriteLine($"{GetType().Name} gets attacked. Loses {damage} hp");
                Hp -= damage;
            }
        }
    }
}