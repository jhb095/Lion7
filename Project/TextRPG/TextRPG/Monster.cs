using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Monster : Unit
    {
        public int ExpReward { get; set; }
        public int GoldReward { get; set; }

        // 드랍 테이블
        internal class DropEntry
        {
            public Func<Item> Factory { get; }
            public double Chance { get; }
            public int Min { get; }
            public int Max { get; }

            public DropEntry(Func<Item> factory, double chance, int min = 1, int max = 1)
            {
                Factory = factory;
                Chance = Math.Clamp(chance, 0.0, 1.0);
                Min = Math.Max(1, min);
                Max = Math.Max(Min, max);
            }
        }

        private readonly List<DropEntry> dropTable = new();

        public Monster(string name, int level, int hp, int attackPower, int defense, double attackSpeed, int expReward, int goldReward)
        {
            Name = name;
            Level = level;
            MaxHP = hp;
            HP = hp;
            AttackPower = attackPower;
            Defense = defense;
            AttackSpeed = attackSpeed;
            ExpReward = expReward;
            GoldReward = goldReward;
        }

        public void AddDrop(Func<Item> factory, double chance, int min = 1, int max = 1)
        {
            dropTable.Add(new DropEntry(factory, chance, min, max));
        }

        public List<Item> GetDrops()
        {
            List<Item> drops = new List<Item>();

            foreach(var entry in dropTable)
            {
                if(Random.Shared.NextDouble() <= entry.Chance)
                {
                    int quantity = (entry.Min == entry.Max) ? entry.Min : Random.Shared.Next(entry.Min, entry.Max + 1);
                    var item = entry.Factory();

                    if(item.IsStackable)
                    {
                        var clone = item.Clone();

                        clone.Add(quantity - 1);
                        drops.Add(clone);
                    } else
                    {
                        for(int i = 0; i < quantity; i++)
                        {
                            drops.Add(item.Clone());
                        }
                    }
                }
            }

            return drops;
        }
    }
}
