using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Unit : IAttackable
    {
        private int hp;
        private int mp;
        private double attackSpeed;

        public string Name { get; set; } = string.Empty;
        public int Level { get; set; } = 1;
        public int HP
        {
            get => hp;
            set => hp = Math.Clamp(value, 0, MaxHP);
        }
        public int MaxHP { get; set; }
        public int MP
        {
            get => mp;
            set => mp = Math.Clamp(value, 0, MaxMP);
        }
        public int MaxMP { get; set; }
        public int AttackPower { get; set; }
        public int Defense { get; set; }
        public double AttackSpeed // 1이면 1초에 1번 공격, 0.5면 1초에 2번 공격
        {
            get => attackSpeed;
            set => attackSpeed = Math.Clamp(value, 0d, 10d);
        }

        public void Attack(IAttackable target)
        {
            int damage = AttackPower - ((Unit)target).Defense;

            if (damage < 0) damage = 0;

            target.TakeDamage(damage);
        }

        public void TakeDamage(int damage)
        {
            HP -= damage;
        }
    }
}
