using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public abstract class AEntity
    {
        public int MaxHp { get; set; } = 100;
        public bool DeadState { get; private set; } = false;
        public int Hp
        {
            get => _hp;
            set
            {
                _hp = (value < 0) ? 0 : value;
                if (_hp == 0)
                {
                    DeadState = true;
                }
                else
                {
                    DeadState = false;
                }
            }
        }
        private int _hp;
        public AEntity(int hp)
        {
            MaxHp = hp;
            Hp = hp;
        }
        public abstract int Attack(int damage);
        public abstract void GetAttacked(int damage);
        public virtual void CantAttack()
        {
            Console.WriteLine($"{GetType().Name} can't attack because they're dead");
        }
        public virtual void CantGetAttacked()
        {
            Console.WriteLine($"{GetType().Name} can't get attacked because they're dead");
        }
    }
}
