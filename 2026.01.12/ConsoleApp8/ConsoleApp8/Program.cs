using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Swap1(int x, int y)
        {
            int temp = x;

            x = y;
            y = temp;
        }

        static void Swap(ref int x, ref int y)
        {
            int temp = x;

            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {
            int x = 10;
            int y = 20;
            //int temp;

            //// swap 두개의 변수 값 바꿔주기
            Swap1(x, y);
            Console.WriteLine($"x: {x} y: {y}");

            Swap(ref x, ref y);
            Console.WriteLine($"x: {x} y: {y}");
        }
    }
}
