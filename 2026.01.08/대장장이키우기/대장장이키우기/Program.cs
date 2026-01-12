using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace 대장장이키우기
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            Console.WriteLine(" 대장장이 키우기 ");

            int pmoney = 100;
            int input;
            int rnd;

            Thread.Sleep(500);

            // 무한 루프
            while (true)
            {
                Console.Clear();

                Console.WriteLine("1. 나무캐기 ");
                Console.WriteLine("2. 장비뽑기 ");
                Console.WriteLine("3. 나가기 ");
                Console.Write("입력: ");

                input = int.Parse(Console.ReadLine());

                // 나무캐기
                if (input == 1)
                {
                    while (true)
                    {
                        Console.WriteLine("나무캐기(엔터)");
                        Console.WriteLine("뒤로가기 x");

                        string str = Console.ReadLine();

                        pmoney += 100;
                        Console.WriteLine("소지금: " + pmoney);

                        if (str == "x")
                        {
                            Console.WriteLine("뒤로가기");

                            break;
                        }
                    }
                }
                // 장비뽑기
                else if (input == 2)
                {
                    if (pmoney >= 1000)
                    {
                        pmoney -= 1000;

                        for (int i = 0; i < 20; i++)
                        {
                            rnd = rand.Next(1, 101);

                            if (rnd == 1) Console.WriteLine("도끼등급 SSS");
                            else if (rnd <= 6) Console.WriteLine("도끼등급 SS");
                            else if (rnd <= 16) Console.WriteLine("도끼등급 S");
                            else if (rnd <= 36) Console.WriteLine("도끼등급 A");
                            else if (rnd <= 66) Console.WriteLine("도끼등급 B");
                            else Console.WriteLine("도끼등급 C");

                            Thread.Sleep(500);
                        }

                        Thread.Sleep(2000);
                    }
                    else
                    {
                        Console.WriteLine("돈이 부족합니다. \n");

                        Thread.Sleep(1000);
                    }
                }
                // 나가기
                else if (input == 3)
                {
                    Console.WriteLine("게임을 나갑니다.");

                    Environment.Exit(0);

                    break;
                }
            }
        }
    }
}
