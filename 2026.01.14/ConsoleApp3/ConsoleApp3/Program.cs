using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class Character
    {
        public virtual void Render()
        {
            Console.WriteLine("캐릭터");
        }
    }

    public class Warrior : Character
    {
        public override void Render()
        {
            Console.WriteLine("전사");
        }
    }

    public class Mage : Warrior
    {
        public override void Render()
        {
            Console.WriteLine("마법사");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character character = new Warrior(); // 업캐스팅
            //Warrior warrior = (Warrior)character; // 다운캐스팅

            //warrior.Render();

            //// is 연산자 문법
            //if (character is Warrior)
            //{
            //    Warrior warrior = (Warrior)character;
            //}

            // as 연산자 문법
            Warrior warrior = character as Warrior;

            if (warrior != null)
            {
                warrior.Render();
            }
        }
    }
}
