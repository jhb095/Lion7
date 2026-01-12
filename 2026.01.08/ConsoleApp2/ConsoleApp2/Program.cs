using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.SetWindowSize(80, 25);  // 콘솔 창 크기 설정
            //Console.SetBufferSize(80, 25);  // 버퍼 크기도 동일하게 설정 (스크롤 방지)

            const int TARGET_X = 100;
            const int TARGET_Y = 40;
            ConsoleKeyInfo keyInfo;
            int x = 10, y = 10;

            Console.OutputEncoding = Encoding.UTF8;

            Console.CursorVisible = false;

            while(true)
            {
                Console.Clear();

                Console.SetCursorPosition(TARGET_X, TARGET_Y);

                Console.Write("🏠");

                Console.SetCursorPosition(x, y);

                Console.Write("●");

                if(x == TARGET_X && y == TARGET_Y)
                {
                    Console.Clear();
                    Console.WriteLine("집에 도착했습니다.");

                    break;
                }

                keyInfo = Console.ReadKey();

                switch(keyInfo.Key)
                {
                    case ConsoleKey.LeftArrow:
                        if (x > 0) x--;
                        else x = Console.WindowWidth - 1;

                        Console.SetCursorPosition(x, y);

                        break;

                    case ConsoleKey.RightArrow:
                        if (x == Console.WindowWidth - 1) x = 0;
                        else x++;

                        Console.SetCursorPosition(x, y);

                        break;

                    case ConsoleKey.UpArrow:
                        if (y > 0) y--;
                        else y = Console.WindowHeight - 1;

                        Console.SetCursorPosition(x, y);

                        break;

                    case ConsoleKey.DownArrow:
                        if (y == Console.WindowHeight - 1) y = 0;
                        else y++;

                        Console.SetCursorPosition(x, y);

                        break;

                    case ConsoleKey.Spacebar:
                        Console.Write("미사일키");

                        break;

                    case ConsoleKey.Escape:
                        break;
                }
            }
        }
    }
}
