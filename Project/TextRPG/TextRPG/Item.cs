using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Item
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public ItemType Type { get; set; }
        public int Price { get; set; } = 0;
        public bool IsStackable { get; set; } = false;
        public int Quantity { get; private set; } = 1;
        public int MaxStack { get; set; } = 99;

        // 장비 효과
        public int AttackBonus { get; set; } = 0;
        public int DefenseBonus { get; set; } = 0;
        public EquipmentSlotType Slot { get; set; } = EquipmentSlotType.None;

        public bool IsEquipped { get; set; } = false;

        private readonly Action<Unit>? useEffect;

        public Item(string name, string description, ItemType type, int price, bool isStackable, int maxStack, int attackBonus = 0, int defenseBonus = 0, EquipmentSlotType slot = EquipmentSlotType.None, Action<Unit>? useEffect = null)
        {
            Name = name;
            Description = description;
            Type = type;
            Price = price;
            IsStackable = isStackable;
            MaxStack = maxStack;
            AttackBonus = attackBonus;
            DefenseBonus = defenseBonus;
            Slot = slot;
            this.useEffect = useEffect;
        }

        public bool Use(Unit player)
        {
            if (useEffect == null) return false;

            useEffect.Invoke(player);

            Quantity--;

            return true;
        }

        // amount만큼 수량 추가
        public void Add(int amount)
        {
            Quantity = Math.Clamp(Quantity + amount, 0, MaxStack);
        }

        public Item Clone(int quantity = 1)
        {
            Item item = new Item(Name, Description, Type, Price, IsStackable, MaxStack, AttackBonus, DefenseBonus, Slot, useEffect);

            item.Add(quantity - 1); // 기본 수량이 1이므로 quantity - 1 만큼 추가

            return item;
        }

        public override string ToString()
        {
            if (IsStackable)
            {
                return $"{Name} x{Quantity} - {Description}";
            }
            else
            {
                return $"{Name} - {Description}";
            }
        }
    }
}
