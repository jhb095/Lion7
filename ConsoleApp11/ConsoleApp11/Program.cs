using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 5, b = 3;
            //int sum = a + b;            // 산술 연산자 사용
            //bool isEqual = (a == b);    // 관계형 연산자 사용

            //Console.WriteLine($"합: {sum}");
            //Console.WriteLine($"a와 b가 같은가? {isEqual}");


            //int number = 5;

            //Console.WriteLine(+number);
            //Console.WriteLine(-number);

            //bool flag = true;

            //Console.WriteLine(!flag);   // 논리 NOT


            //int a = 10, b = 3;

            //Console.WriteLine(a + b);
            //Console.WriteLine(a - b);
            //Console.WriteLine(a * b);
            //Console.WriteLine(a / b);
            //Console.WriteLine(a % b);


            int a = 5, b = 4, sum;

            //sum = a + b;

            // 할당 연산자
            a += b;
            Console.WriteLine($"+: {a}");
            a = 5;

            a -= b;
            Console.WriteLine($"-: {a}");
            a = 5;

            a *= b;
            Console.WriteLine($"*: {a}");
            a = 5;

            a /= b;
            Console.WriteLine($"/: {a}");
            a = 5;

            a %= b;
            Console.WriteLine($"%: {a}");
        }
    }
}
