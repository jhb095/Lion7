using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int level = 7;
            int vigor = 14;
            int mind = 9;
            int endurance = 12;
            int strength = 16;
            int dexterity = 9;
            int intelligence = 7;
            int faith = 8;
            int arcane = 11;

            Console.CursorVisible = false;
            int top = Console.CursorTop;
            bool showArrow = true;

            void DrawArrow(bool onArrow)
            {
                string arrow = onArrow ? "▶" : " ";
                var lines = new[]
{
                        "┏━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┓",
                        $"┃  \tlevel       \t\t{level}\t┃",
                        $"┃  {arrow}\tvigor       \t\t{vigor}\t┃",
                        $"┃  \tmind        \t\t{mind}\t┃",
                        $"┃  \tendurance   \t\t{endurance}\t┃",
                        $"┃  \tstrength    \t\t{strength}\t┃",
                        $"┃  \tdexterity   \t\t{dexterity}\t┃",
                        $"┃  \tintelligence\t\t{intelligence}\t┃",
                        $"┃  \tfaith       \t\t{faith}\t┃",
                        $"┃  \tarcane      \t\t{arcane}\t┃",
                        "┗━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━┛"
                    };

                Console.SetCursorPosition(0, top);
                foreach (var line in lines)
                {
                    Console.WriteLine(line.PadRight(0));
                }
            }

            while (true)
            {
                DrawArrow(showArrow);
                showArrow = !showArrow;

                 Thread.Sleep(500);
            }
        }
    }
}
