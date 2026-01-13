using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Character
    {
        //private int att; // 은닉성

        ////Get, Set 메서드
        //public void SetAtt(int _att)
        //{
        //    att = _att;
        //}

        //public int GetAtt()
        //{
        //    return att;
        //}

        public int Att { get; set; }    // 자동 프로퍼티

        // 읽기 전용
        public int MaxHP { get; private set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Character c = new Character();

            c.Att = 1;

            Console.WriteLine($"공격력: {c.Att}");
        }
    }
}
