using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 클래스끼리 통신
    class Player
    {
        private int hp;
        private int att;

        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;

                if(hp < 0) hp = 0;
            }
        }

        public int Att { get; set; }

        public void Render()
        {
            Console.WriteLine("플레이어");
            Console.WriteLine($"체력: {hp}");
            Console.WriteLine($"공격력: {att}\n");
        }
    }

    class Monster
    {
        private int hp;
        private int att;

        public int HP
        {
            get { return hp; }
            set
            {
                hp = value;

                if (hp < 0) hp = 0;
            }
        }

        public int Att { get; set; }

        public void Render()
        {
            Console.WriteLine("몬스터");
            Console.WriteLine($"체력: {hp}");
            Console.WriteLine($"공격력: {att}\n");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 플레이어 객체
            Player player = new Player();

            player.HP = 100;
            player.Att = 10;

            player.Render();

            // 몬스터 객체
            Monster monster = new Monster();

            monster.HP = 100;
            monster.Att = 5;

            monster.Render();

            monster.HP -= player.Att;
            player.HP -= monster.Att;

            player.Render();
            monster.Render();
        }
    }
}
