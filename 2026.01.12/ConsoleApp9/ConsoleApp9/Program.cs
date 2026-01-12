using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        // 1부터 n까지의 합 구하기
        static int SumToN(int n)
        {
            if(n == 0) return 0;

            return n + SumToN(n - 1);
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumToN(10));
        }
    }
}
