using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int x = 10, y = 20, z = 30;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(z);


            //int age = 20;
            //int level = 100;

            //Console.WriteLine("나이: {0}", age);

            //string name = "철수";

            //Console.WriteLine("이름: {0}, 나이: {1}", name, age);
            //Console.WriteLine("나이: " + age);
            //Console.WriteLine($"나이: {age} 레벨: {level}");

            int posX = 0, posY = 50, posZ = 100;

            Console.WriteLine("X: {0} Y: {1} Z: {2}", posX, posY, posZ);
            Console.WriteLine("X: " + posX + " Y: " + posY + " Z: " + posZ);
            Console.WriteLine($"X: {posX} Y: {posY} Z: {posZ}");

            int red = 255, green = 128, blue = 0;

            Console.WriteLine("R: {0} G: {1} B: {2}", red, green, blue);
            Console.WriteLine("R: " + red + " G: " + green + " B: " + blue);
            Console.WriteLine($"R: {red} G: {green} B: {blue}");
        }
    }
}
