using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class MainGame
    {
        private Player player = null;
        private Field field = null;

        // 초기화해주는 함수
        public void Initialize()
        {
            // 플레이어 생성 및 직업 선택
            player = new Player(); // 객체

            player.SelectJob();
        }

        // 게임의 전체적인 과정 관리
        public void Progress()
        {
            string input;

            while (true)
            {
                Console.Clear();

                player.Render(); // 플레이어 출력

                Console.Write("1. 사냥터 2. 종료: ");

                input = Console.ReadLine();

                if (!int.TryParse(input, out int selected)) continue;
                
                switch (selected)
                {
                    case 1:
                        // 사냥터 구현
                        if (field == null)
                        {
                            field = new Field();

                            // 필드로 갈때 플레이어 넣어주기
                            field.SetPlayer(player);
                        }

                        field.Progress(); // 사냥터 동작

                        break;

                    case 2:
                        Environment.Exit(0);

                        break;
                }
            }
        }
    }
}
