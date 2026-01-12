using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        //static void CastFireBall(string target, int damage = 100, int manaCost = 30)
        //{
        //    Console.WriteLine($" 파이어볼 시전!");
        //    Console.WriteLine($" 대상: {target}");
        //    Console.WriteLine($" 데미지: {damage}");
        //    Console.WriteLine($" 마나 소모: {manaCost}");
        //}

        static void UsePotion(string itemName = "회복 포션", int recoveryHP = 50)
        {
            Console.WriteLine($"💊 {itemName} 사용!");
            Console.WriteLine($"회복량: {recoveryHP} HP\n");
        }

        static void SummonMagic(string monsterName = "슬라임", int level = 1, int cnt = 1)
        {
            Console.WriteLine($"✨ {monsterName} 소환!");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"수량: {cnt}마리\n");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //// 모든 매개변수 지정
            //CastFireBall("고블린", 150, 40);
            //Console.WriteLine(
            //    );
            //CastFireBall("고블린", manaCost: 50);
            //Console.WriteLine();

            //CastFireBall("오크", 20);
            //Console.WriteLine();

            //CastFireBall("드래곤");
            //Console.WriteLine();

            Console.WriteLine("=== 아이템 사용 ===\n");

            UsePotion();
            UsePotion("고급 회복 포션", 100);

            Console.WriteLine("=== 소환 마법 ===\n");

            SummonMagic();
            SummonMagic("고블린", 5);
            SummonMagic("드래곤", 50, 3);
        }
    }
}
