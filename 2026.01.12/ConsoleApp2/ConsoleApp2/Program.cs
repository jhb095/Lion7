using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        //// int 넘겨보기 2매개변수 입력쪽 활용
        //static void Attack(int att, int def)
        //{
        //    Console.WriteLine($"공격력 전달받았다. : {att}");
        //    Console.WriteLine($"방어력 : {def}");
        //}
        
        //static void ShowInfo(string playerName, int att, int def, int dex, int luck)
        //{
        //    Console.WriteLine($"플레이어이름: {playerName}");
        //    Console.WriteLine($"공격력: {att}");
        //    Console.WriteLine($"방어력: {def}");
        //    Console.WriteLine($"민첩: {dex}");
        //    Console.WriteLine($"운: {luck}");
        //}

        static void GreetPlayer(string playerName)
        {
            Console.WriteLine($"환영합니다. {playerName}님!");
        }

        static void ShowPlayerInfo(string job, int level)
        {
            Console.WriteLine($"직업: {job}");
            Console.WriteLine($"레벨: {level}");
        }

        // 매개변수 3개 체력바 출력
        static void DrawHealthBar(int current, int max, int barLength)
        {
            Console.Write("HP [");

            int filledLength = (int)((double)current / max * barLength);

            for(int i = 0; i < barLength; i++)
            {
                if(i < filledLength)
                    Console.Write("■");
                else
                    Console.Write("□");
            }

            Console.WriteLine($"] {current}/{max}");
        }

        // 데미지 계산 출력
        static void ShowDamage(string attacker, string target, int damage)
        {
            Console.WriteLine($"{attacker}의 공격!");
            Console.WriteLine($"    {target}에게 {damage} 데미지!");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 함수 호출 시 인자 전달
            GreetPlayer("홍길동");
            Console.WriteLine();

            ShowPlayerInfo("전사", 50);
            Console.WriteLine();

            DrawHealthBar(75, 100, 20);
            DrawHealthBar(30, 100, 20);
            DrawHealthBar(100, 100, 20);
            Console.WriteLine();

            ShowDamage("플레이어", "고블린", 85);
            Console.WriteLine();
            ShowDamage("드래곤", "플레이어", 120);
        }
    }
}
