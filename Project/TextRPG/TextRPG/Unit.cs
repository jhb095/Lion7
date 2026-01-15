using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Unit : IAttackable
    {
        private string name;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;
        private int attack;
        private int defense;
        private double attackSpeed;
        private double criticalChance;
        private double criticalDamage;

        public void Attack(IAttackable target)
        {
            target.TakeDamage(this.attack);
        }

        public void TakeDamage(int damage)
        {
            this.hp = damage;
        }
    }
}
