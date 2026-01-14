using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ShootingGame
{
    public class ConsoleClear
    {
        private int score;
        private (int x, int y) player;
        private (int x, int y) enemy;
    }

    // 미사일 클래스
    public class Bullet
    {
        public int x;
        public int y;
    }

    // 플레이어 클래스
    public class Player
    {
        [DllImport("msvcrt.dll")]
        static extern int _getch(); // c언어 함수

        public const int MAXPOOL = 20;

        public int x; // 플레이어 x좌표
        public int y; // 플레이어 y좌표

        public List<Bullet> playerBullet = new List<Bullet>();
        public List<Bullet> firedBullet = new List<Bullet>();
        public int score;

        // 아이템
        public Item item = new Item();
        public int itemCount;

        // 생성자
        public Player()
        {
            // 플레이어 좌표위치 초기화
            x = 0;
            y = 12;

            // 20개 먼저 생성 후 준비된 미사일 활용(오브젝트풀)

            for (int i = 0; i < MAXPOOL; i++)
            {
                Bullet bullet = new Bullet();

                bullet.x = 0;
                bullet.y = 0;

                playerBullet.Add(bullet);
            }
        }

        public void GameMain()
        {
            KeyControl();
            PlayerDraw();
            UIScore();

            if (item.ItemLife)
            {
                item.ItemDraw();

                CollisionItem();
            }
        }

        // 키를 입력하는 부분
        public void KeyControl()
        {
            int pressKey; // 키 값

            if (Console.KeyAvailable)
            {
                pressKey = _getch(); // 아스키값

                if (pressKey == 224) pressKey = _getch();

                switch (pressKey)
                {
                    // 위 방향키
                    case 72:
                        y--;

                        if (y < 1) y = 1;

                        break;

                    // 왼쪽
                    case 75:
                        x--;

                        if (x < 1) x = 1;

                        break;

                    // 오른쪽
                    case 77:
                        x++;

                        if (x > 115) x = 115;

                        break;

                    // 아래
                    case 80:
                        y++;

                        if (y > 25) y = 25;

                        break;

                    // 스페이스바
                    case 32:
                        // 미사일 발사
                        int[] bulletY = new int[] { 1, 0, 2 };
                        int cnt = 0;

                        for (int i = playerBullet.Count - 1; i >= 0; i--)
                        {
                            Bullet bullet = playerBullet[i];

                            bullet.x = x + 5;
                            bullet.y = y + bulletY[cnt++];

                            firedBullet.Add(bullet);
                            playerBullet.Remove(bullet);

                            if (cnt > itemCount) break;
                        }

                        break;
                }
            }
        }

        // 미사일 그리기
        public void BulletDraw()
        {
            string bulletStr = "->"; // 미사일 모습

            for (int i = firedBullet.Count - 1; i >= 0; i--)
            {
                Bullet bullet = firedBullet[i];

                Console.SetCursorPosition(bullet.x - 1, bullet.y);
                Console.Write(bulletStr);

                bullet.x++;

                if (bullet.x > 118)
                {
                    playerBullet.Add(bullet);
                    firedBullet.Remove(bullet);
                }
            }
        }

        // 플레이어 그리기
        public void PlayerDraw()
        {
            string[] player = new string[]
            {
                "->",
                ">>>",
                "->"
            };

            for (int i = 0; i < player.Length; i++)
            {
                // 좌표 설정 및 그리기
                Console.SetCursorPosition(x, y + i);
                Console.Write(player[i]);
            }
        }

        // UI 점수
        public void UIScore()
        {
            Console.SetCursorPosition(103, 0);
            Console.Write("┏━━━━━━━━━━━━━━┓");
            Console.SetCursorPosition(103, 1);
            Console.Write("┃              ┃");
            Console.SetCursorPosition(105, 1);
            Console.Write("Score : " + score);
            Console.SetCursorPosition(103, 2);
            Console.Write("┗━━━━━━━━━━━━━━┛");
        }

        // 충돌처리
        public void CollisionEnemyAndBullet(Enemy enemy)
        {
            for (int i = firedBullet.Count - 1; i >= 0; i--)
            {
                Bullet bullet = firedBullet[i];

                if (bullet.y == enemy.y)
                {
                    // 충돌
                    if (bullet.x >= enemy.x - 1 && bullet.x <= enemy.x + 1)
                    {
                        item.ItemLife = true;
                        item.x = enemy.x;
                        item.y = enemy.y;

                        Random rand = new Random();

                        enemy.x = 115;
                        enemy.y = rand.Next(2, 22);

                        playerBullet.Add(bullet);
                        firedBullet.Remove(bullet);

                        // 스코어
                        score += 100;
                    }
                }
            }
        }

        // 아이템 충돌시 미사일 수 증가
        public void CollisionItem()
        {
            if (y + 1 == item.y)
            {
                if (x >= item.x - 2 && x <= item.x + 2)
                {
                    item.ItemLife = false;

                    if (itemCount < 2) itemCount++;
                }
            }
        }
    }

    // 적 클래스
    public class Enemy
    {
        public int x; // x좌표
        public int y; // y좌표

        public Enemy()
        {
            // 적 좌표 초기화
            x = 117;
            y = 12;
        }

        // 적 그리기
        public void EnemyDraw()
        {
            string enemy = "<-0->";

            Console.SetCursorPosition(x, y);
            Console.Write(enemy);
        }

        public void EnemyMove()
        {
            Random rand = new Random();

            x--;

            // 화면 왼쪽 넘어가면 새로 좌표 잡기
            if (x < 2)
            {
                x = 115;
                y = rand.Next(2, 22);
            }
        }
    }

    // 아이템 클래스
    public class Item
    {
        public string ItemName;
        public string ItemSprite;
        public int x;
        public int y;
        public bool ItemLife = false;

        public void ItemDraw()
        {
            ItemSprite = "Item★";

            Console.SetCursorPosition(x, y);
            Console.Write(ItemSprite);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;

            Player player = new Player();
            Enemy enemy = new Enemy();

            // 콘솔 속도 만들기
            int dwTime = Environment.TickCount;

            while (true)
            {
                // 0.05초 지연
                if (dwTime + 50 < Environment.TickCount)
                {
                    dwTime = Environment.TickCount;

                    Console.Clear();

                    player.GameMain();

                    player.BulletDraw();
                    enemy.EnemyMove();
                    enemy.EnemyDraw();

                    player.CollisionEnemyAndBullet(enemy);
                }
            }
        }
    }
}
