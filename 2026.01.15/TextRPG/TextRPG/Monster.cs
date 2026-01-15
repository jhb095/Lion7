using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Monster
    {
        private Info info; // 몬스터 정보

        public void SetDamage(int attack) { info.hp -= attack; }

        // Info클래스 타입 인자로 몬스터 정보를 넣어준다.
        public void SetMonster(Info monster) { info = monster; }

        public Info GetInfo() { return info; }

        public void Render()
        {
            Console.WriteLine("================================");
            Console.WriteLine($"몬스터 이름: {info.name}");
            Console.WriteLine($"체력: {info.hp}\t공격력: {info.attack}");
        }

        public Monster() { }

        ~Monster() { }
    }
}
