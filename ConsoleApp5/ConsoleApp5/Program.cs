using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int level           = 7;
            int vigor           = 14;
            int mind            = 9;
            int endurance       = 12;
            int strength        = 16;
            int dexterity       = 9;
            int intelligence    = 7;
            int faith           = 8;
            int arcane          = 11;

            Console.WriteLine("┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓");
            Console.WriteLine($"┃\tlevel       \t\t{level}\t┃");
            Console.WriteLine($"┃\tvigor       \t\t{vigor}\t┃");
            Console.WriteLine($"┃\tmind        \t\t{mind}\t┃");
            Console.WriteLine($"┃\tendurance   \t\t{endurance}\t┃");
            Console.WriteLine($"┃\tstrength    \t\t{strength}\t┃");
            Console.WriteLine($"┃\tdexterity   \t\t{dexterity}\t┃");
            Console.WriteLine($"┃\tintelligence\t\t{intelligence}\t┃");
            Console.WriteLine($"┃\tfaith       \t\t{faith}\t┃");
            Console.WriteLine($"┃\tarcane      \t\t{arcane}\t┃");
            Console.WriteLine("┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛");
        }
    }
}
