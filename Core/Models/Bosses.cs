using System;
using System.Collections.Generic;
using System.Text;

namespace HeroEngine.Core.Models
{
    public class Bosses: AEnemy
    {
        public static int _bossesHp = 100;

        public Bosses(string name, int hp) : base(name, hp)
        {
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
