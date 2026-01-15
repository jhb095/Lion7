using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // 추상클래스 상속을 받고 있으면 반드시 추상메서드를 구현해야 한다
    public abstract class Character
    {
        public int hp;
        public string job;

        public abstract void Job();
    }

    public class Mage : Character
    {
        public Mage()
        {
            hp = 100;
            job = "마법사";
        }

        public override void Job()
        {
            Console.WriteLine($"직업: {job}");
        }
    }

    public class Archer : Character
    {
        public Archer()
        {
            hp = 100;
            job = "궁수";
        }

        public override void Job()
        {
            Console.WriteLine($"직업: {job}");
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //Mage mage = new Mage();

            //mage.Job();

            Character[] ch = new Character[2];

            ch[0] = new Mage();
            ch[1] = new Archer();

            foreach(Character c in ch)
            {
                c.Job();
            }
        }
    }
}
