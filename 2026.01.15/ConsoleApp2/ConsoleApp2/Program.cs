using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public abstract class Unit
    {
        protected string name;
        protected string job;
        protected int hp;
        protected int maxHP;
        protected int moveSpeed;

        public Unit(string name, int hp, int moveSpeed)
        {
            this.name = name;
            this.maxHP = hp;
            this.hp = hp;
            this.moveSpeed = moveSpeed;
        }

        public abstract void ShowStatus();
    }

    public class Warrior : Unit
    {
        private int attack;
        private int defense;

        public Warrior(string name) : base(name, 200, 5)
        {
            attack = 80;
            defense = 50;
        }

        public override void ShowStatus()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[전사]: {name}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"방어력: {defense}");
            Console.WriteLine($"이동속도: {moveSpeed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━\n");
        }
    }

    public class Mage : Unit
    {
        private int magicPower;
        private int mana;

        public Mage(string name) : base(name, 120, 4)
        {
            magicPower = 150;
            mana = 100;
        }
        public override void ShowStatus()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[마법사]: {name}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"마력: {magicPower}");
            Console.WriteLine($"마나: {mana}");
            Console.WriteLine($"이동속도: {moveSpeed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━\n");
        }
    }

    public class Archer : Unit
    {
        public int attack;
        public int arrow;

        public Archer(string name) : base(name, 150, 6)
        {
            attack = 100;
            arrow = 50;
        }
        public override void ShowStatus()
        {
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"[궁수]: {name}");
            Console.WriteLine($"HP: {hp}/{maxHP}");
            Console.WriteLine($"공격력: {attack}");
            Console.WriteLine($"화살: {arrow}");
            Console.WriteLine($"이동속도: {moveSpeed}");
            Console.WriteLine("━━━━━━━━━━━━━━━━━━━━\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Unit[] units = new Unit[3];

            units[0] = new Warrior("홍길동");
            units[1] = new Mage("김마법");
            units[2] = new Archer("이궁수");

            foreach(Unit unit in units)
            {
                unit.ShowStatus();
            }
        }
    }
}
