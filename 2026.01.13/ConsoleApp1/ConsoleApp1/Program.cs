using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Character
    {
        // public은 다른 곳에서 사용가능하게 한다.
        // private은 클래스 나 자신 내부에서만 사용할 수 있다.
        // 필드(Field): 클래스의 데이터
        private string name;
        private int level;
        private int hp;
        private int maxHP;
        private int mp;
        private int maxMP;

        // 기본 생성자. 초기화 용도로 많이 사용
        public Character()
        {
            name = "홍길동";
            level = 1;
            hp = 100;
            maxHP = 150;
            mp = 80;
            maxMP = 100;
        }

        // 인자 있는 생성자
        public Character(string _name, int _level, int _hp, int _maxHP, int _mp, int _maxMP)
        {
            name = _name;
            level = _level;
            hp = _hp;
            maxHP = _maxHP;
            mp = _mp;
            maxMP = _maxMP;
        }

        // 메서드(Method): 클래스의 기능
        public void ShowStats()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"레벨: {level}");
            Console.WriteLine($"Hp: {hp}/{maxHP}");
            Console.WriteLine($"Mp: {mp}/{maxMP}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━━━━━");
        }

        public void TakeDamage(int damage)
        {
            hp -= damage;

            if(hp < 0) hp = 0;

            Console.WriteLine($"⚔️ {name}이(가) {damage} 데미지를 받았습니다!");
            Console.WriteLine($"\t남은 HP: {hp}/{maxHP}");
        }

        public void Heal(int amount)
        {
            hp += amount;

            if(hp > maxHP) hp = maxHP;

            Console.WriteLine($"💚 {name}의 HP가 {amount} 회복되었습니다!");
            Console.WriteLine($"\t현재 HP: {hp}/{maxHP}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // 객체 생성
            Character player = new Character(); // 생성자 호출

            player.ShowStats();

            player.TakeDamage(50);
            player.Heal(30);

            Character player2 = new Character("마법사", 2, 110, 250, 80, 100);

            player2.ShowStats();
        }
    }
}