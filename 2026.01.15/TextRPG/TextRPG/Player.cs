using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Player
    {
        private Info info;

        // 데미지를 입는 함수
        public void SetDamage(int iAttack) { info.hp -= iAttack; }

        // 플레이어 정보를 외부에서 볼 수 있는 함수
        public Info GetInfo() { return info; }

        // hp를 다시 설정해주는 함수
        public void SetHp(int iHp) { info.hp = iHp; }

        // 직업 선택
        public void SelectJob()
        {
            string input;

            info = new Info();

            while (true)
            {
                Console.Write("직업을 선택하세요(1.기사 2.마법사 3.도둑): ");

                input = Console.ReadLine();

                if ((!int.TryParse(input, out int selected))) continue;

                switch (selected)
                {
                    case 1:
                        info.name = "기사";
                        info.hp = 100;
                        info.attack = 10;

                        return;

                    case 2:
                        info.name = "마법사";
                        info.hp = 90;
                        info.attack = 15;

                        return;

                    case 3:
                        info.name = "도둑";
                        info.hp = 85;
                        info.attack = 13;

                        return;
                }
            }
        }

        public void Render()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"직업 이름: {info.name}");
            Console.WriteLine($"체력: {info.hp}\t공격력: {info.attack}");
        }

        // 생성자
        public Player() { }

        // 소멸자
        ~Player() { }
    }
}
