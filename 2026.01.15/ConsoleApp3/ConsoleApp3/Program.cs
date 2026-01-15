using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    interface IAttackable
    {
        void Attack(string target);
        int GetAttackPower();
    }

    interface IDefendable
    {
        void Defend();
        int GetDefensePower();
    }

    class Knight : IAttackable, IDefendable
    {
        public string name;
        public int attackPower;
        public int defensePower;

        public Knight()
        {
            name = "검사";
            attackPower = 10;
            defensePower = 5;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"검으로 {target}을(를) 공격했습니다.");
        }

        public void Defend()
        {
            Console.WriteLine("기사가 방어모드중입니다.");
        }

        public int GetAttackPower()
        {
            return attackPower;
        }

        public int GetDefensePower()
        {
            return defensePower;
        }
    }

    class Mage : IAttackable
    {
        public string name;
        public int magicPower;

        public Mage()
        {
            name = "마법사";
            magicPower = 10;
        }

        public void Attack(string target)
        {
            Console.WriteLine($"마법으로 {target}을(를) 공격했습니다.");
        }

        public int GetAttackPower()
        {
            return magicPower;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //Knight knight = new Knight();

            //knight.Attack("오크");

            //Mage mage = new Mage();

            //mage.Attack("고블린"); 

            IAttackable[] attacker = new IAttackable[2];

            attacker[0] = new Knight();
            attacker[1] = new Mage();

            foreach (IAttackable att in attacker)
            {
                att.Attack("오크");
            }

            IDefendable defender = new Knight();

            defender.Defend();
        }
    }
}
