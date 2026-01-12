using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        // 정수 반환
        static int GetNumber()
        {
            return 42;
        }


        // 문자열 반환 2단계 입력 / 반환
        static string GetString(string name)
        {
            return $"{name}님 접속하셨습니다.";
        }

        static void Main(string[] args)
        {
            int num = GetNumber();

            Console.WriteLine($"숫자 반환: {num}");

            string str = GetString("홍길동");

            Console.WriteLine(str);
        }
    }
}
