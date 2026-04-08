using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public abstract class AEnemy: AEntity
    {
        protected AEnemy(string name, int hp) : base(name, hp)
        {
        }

        public override string ToString()
        {
            return $"[{GetType().Name}] | HP: {Hp}/{MaxHp}";
        }
    }
}