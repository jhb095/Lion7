using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //const double Pi = 3.14159;
            //const int MaxScore = 100;

            //Console.WriteLine("Pi: " + Pi);
            //Console.WriteLine("Max Score: " + MaxScore);

            ////Pi = 3.14 // 상수는 값 변경 불가

            const int MaxPlayer = 4;
            const int StartGold = 1000;
            const string Version = "1.0.0";

            Console.WriteLine("=== 게임 설정 ===");
            Console.WriteLine("최대 플레이어: " + MaxPlayer + "명");
            Console.WriteLine("시작 골드: " + StartGold + "G");
            Console.WriteLine("버전: " + Version);
        }
    }
}
