using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("=== 예제 2: 카운트다운 ===");
            //int countdown = 10;

            //while (countdown > 0)
            //{
            //    Console.WriteLine(countdown--);
            //}


            //Console.WriteLine("=== 예제 3: 합계 구하기 ===");
            //int sum = 0, i = 1;

            //while(i <= 5)
            //{
            //    sum += i++;
            //}

            //Console.WriteLine(sum);


            //Console.WriteLine("=== 예제 4: 목표 달성하기 ===");

            //int coins = 0;
            //int target = 50;
            //int day = 0;

            //while(coins < target)
            //{
            //    Console.WriteLine($"{++day}일차: 코인 {coins += 10}개");
            //}

            //Console.WriteLine($"🎉 목표 달성! {day}일 걸렸습니다.");


            //int x = 5;

            //do
            //{
            //    Console.WriteLine("최소 한번 실행됩니다.");
            //} while (--x > 0);


            //string choice;
            //int totalPrice = 0;

            //do
            //{
            //    Console.WriteLine("메뉴판");
            //    Console.WriteLine($"1. 짜장면 - {5000:N0}원");
            //    Console.WriteLine($"2. 짬뽕 - {6000:N0}원");
            //    Console.WriteLine($"3. 탕수육 - {15000:N0}원");
            //    Console.WriteLine($"4. 볶음밥 - {7000:N0}원");
            //    Console.WriteLine("0. 주문 완료");
            //    Console.WriteLine("============================");
            //    Console.Write("메뉴 번호를 선택하세요: ");

            //    choice = Console.ReadLine();

            //    switch(choice)
            //    {
            //        case "1":
            //            Console.WriteLine($"짜장면 추가! (+{5000:N0}원)");
            //            totalPrice += 5000;

            //            break;

            //        case "2":
            //            Console.WriteLine($"짬뽕 추가! (+{6000:N0}원)");
            //            totalPrice += 6000;

            //            break;

            //        case "3":
            //            Console.WriteLine($"탕수육 추가! (+{15000:N0}원)");
            //            totalPrice += 15000;

            //            break;

            //        case "4":
            //            Console.WriteLine($"볶음밥 추가! (+{7000:N0}원)");
            //            totalPrice += 7000;

            //            break;

            //        case "0":
            //            Console.WriteLine("주문을 완료합니다.");

            //            break;

            //        default:
            //            Console.WriteLine("잘못된 선택입니다.");

            //            break;
            //    }

            //    if(choice != "0")
            //    {
            //        Console.WriteLine($"현재 총액: {totalPrice:N0}원");
            //    }

            //    Console.WriteLine();
            //} while (choice != "0");


            //for(int i = 1; i < 10; i++)
            //{
            //    if (i % 2 == 0) continue;

            //    Console.WriteLine(i);
            //}


            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write("⬜");
            //    }

            //    Console.WriteLine();
            //}


            //for(int i = 1; i <= 3; i++)
            //{
            //    for(int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{j} ");
            //    }

            //    Console.WriteLine();
            //}


            //for(int i = 0; i < 3; i++)
            //{
            //    for(int j = 0; j < 3; j++)
            //    {
            //        Console.Write($"({j}, {i})");
            //    }

            //    Console.WriteLine();
            //}


            //for(int i = 0; i < 5; i++)
            //{
            //    for(int j = 0; j <= i; j++)
            //    {
            //        Console.Write("★");
            //    }

            //    Console.WriteLine();
            //}


            //for(int i = 1; i <= 3; i++)
            //{
            //    for(int j = 1; j <= 3; j++)
            //    {
            //        Console.Write($"{i}x{j} = {i * j}  ");
            //    }

            //    Console.WriteLine();
            //}


            ////=== 예제 9: 미니 게임 맵 ===
            ////🏠 🟩 🟩 🟩 
            ////🟩 🟩 🟩 🟩 
            ////🟩 🟩 🟩 🟩 
            ////🟩 🟩 🟩 🎯

            //for (int i = 0; i < 4; i++)
            //{
            //    for (int j = 0; j < 4; j++)
            //    {
            //        if (i == 0 && j == 0)
            //        {
            //            Console.Write("🏠 ");
            //        }
            //        else if (i == 3 && j == 3)
            //        {
            //            Console.Write("🎯 ");
            //        }
            //        else
            //        {
            //            Console.Write("🟩 ");
            //        }
            //    }

            //    Console.WriteLine();
            //}
        }
    }
}
