using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); // c언어 함수 가져오기
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);

            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };  // 배열 문자열로 그리기

            int playerX = 0;
            int playerY = 12;
            List<(int x, int y)> missile = new List<(int, int)>();

            ConsoleKeyInfo keyInfo; // 키 정보

            Console.CursorVisible = false;  // 콘솔창 커서 안보이게하기

            int dwTime = Environment.TickCount; // 1/1000 초

            while (true)
            {

                if (dwTime + 20 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;

                    for (int i = 0; i < player.Length; i++)
                    {
                        Console.SetCursorPosition(playerX, playerY + i);
                        Console.WriteLine("     ");
                    }

                    int pressKey;

                    // 키가 눌렸는지
                    if(Console.KeyAvailable)
                    {
                        pressKey = _getch();

                        if (pressKey == 224) pressKey = _getch();

                        switch (pressKey)
                        {
                            //위쪽방향 아스키코드                    
                            case 72:
                                playerY--;
                                if (playerY < 1)
                                    playerY = 1;
                                break;

                            //왼쪽 화살표키
                            case 75:
                                playerX--;
                                if (playerX < 0)
                                    playerX = 0;
                                break;

                            //오른쪽
                            case 77:
                                playerX++;
                                if (playerX > 75)
                                    playerX = 75;
                                break;

                            //아래
                            case 80:
                                playerY++;
                                if (playerY > 21)
                                    playerY = 21;
                                break;

                            // 스페이스바
                            case 32:
                                missile.Add((playerX + 2, playerY + 1));

                                break;
                        }
                    }

                    for (int i = 0; i < player.Length; i++)
                    {
                        // 콘솔 좌표 설정 플레이어x 플레이어y
                        Console.SetCursorPosition(playerX, playerY + i);

                        Console.WriteLine(player[i]);
                    }

                    for(int i = 0; i < missile.Count; i++)
                    {
                        Console.SetCursorPosition(missile[i].x, missile[i].y);
                        Console.Write(" ");

                        if (missile[i].x == 75)
                        {
                            missile.Remove(missile[i]);
                        }
                        else
                        {
                            missile[i] = (missile[i].x + 1,  missile[i].y);

                            Console.SetCursorPosition(missile[i].x, missile[i].y);

                            Console.WriteLine("▶");
                        }
                    }
                }
            }
        }
    }
}
