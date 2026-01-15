using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Field
    {
        Player player;
        Monster monster;

        // 메인게임쪽에서 플레이어 데이터 전달받아서 필드로 가져옴
        public void SetPlayer(Player pPlayer) { player = pPlayer; }

        public void Progress()
        {
            // 사냥터
            string input;

            while (true)
            {
                Console.Clear();

                player.Render();

                // 맵
                DrawMap();

                input = Console.ReadLine();

                if (!int.TryParse(input, out int selected)) continue;
                if (selected < 1 || selected > 4) continue;

                if (selected == 4) break;

                // 몬스터 생성
                CreateMonster(selected);

                // 전투
                Fight();
            }
        }

        private void DrawMap()
        {
            Console.WriteLine("1. 초보맵");
            Console.WriteLine("2. 중수맵");
            Console.WriteLine("3. 고수맵");
            Console.WriteLine("4. 전단계");
            Console.WriteLine("==============");
            Console.Write("맵을 선택하세요: ");
        }

        // 생성을 도와주는 함수
        // 팩토리 메서드
        private void Create(string name, int hp, int attack, out Monster monster)
        {
            monster = new Monster();

            monster.SetMonster(new Info(name, hp, attack));
        }

        private void CreateMonster(int input)
        {
            switch (input)
            {
                case 1:
                    // 디자인 패턴: 팩토리 메서드 패턴
                    Create("고블린", 30, 3, out monster);

                    break;

                case 2:
                    Create("오크", 60, 6, out monster);

                    break;

                case 3:
                    Create("트롤", 90, 9, out monster);

                    break;
            }
        }

        private void Fight()
        {
            string input;

            while (true)
            {
                Console.Clear();

                player.Render();    // 플레이어 정보 출력
                monster.Render();   // 몬스터 정보 출력

                Console.Write("1. 공격 2. 도망: ");

                input = Console.ReadLine();

                if ((!int.TryParse(input, out int selected))) continue;

                // 공격
                if (selected == 1)
                {
                    // 몬스터 피해 받기
                    monster.SetDamage(player.GetInfo().attack);

                    if (monster.GetInfo().hp <= 0)
                    {
                        // 참조일 때 null로 만들어줘야 가비지 컬렉터가 메모리를 해제함
                        monster = null;

                        break;
                    }

                    // 플레이어 피해 받기
                    player.SetDamage(monster.GetInfo().attack);

                    if (player.GetInfo().hp <= 0)
                    {
                        // 플레이어 사망
                        Console.WriteLine("You Died");

                        Thread.Sleep(1000);
                        break;
                    }
                }
                else
                {
                    // 도망
                    monster = null;
                }
            }
        }
    }
}
