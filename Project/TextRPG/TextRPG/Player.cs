using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class Player : Unit
    {
        public int exp;
        public JobType Job { get; set; }
        public string JobName
        {
            get
            {
                return Job switch
                {
                    JobType.Warrior => "⚔️ 전사",
                    JobType.Mage => "🔮 마법사",
                    JobType.Rogue => "🗡️ 도적",
                    _ => "없음",
                };
            }
        }
        public int Exp
        {
            get => exp;
            set
            {
                int gainedExp = value - exp;

                if (exp + gainedExp >= NeedExp)
                {
                    exp += gainedExp - NeedExp;
                    ShowLevelUp();
                }
                else
                {
                    exp += gainedExp;
                }
            }
        }
        public int NeedExp
        {
            get
            {
                return Level * 100;
            }
        }
        public int Gold { get; set; } = 0;
        public List<Item> Inventory { get; } = new List<Item>();
        public List<Item> EquippedItems { get; } = new List<Item>();

        public Player()
        {
            Initialize();
        }

        private void Initialize()
        {
            CreateCharacter();
        }

        // 인벤토리에 아이템 추가
        public void AddItem(Item item)
        {
            if (item.IsStackable)
            {
                Item? inventoryItem = Inventory.FirstOrDefault(i => i.Name == item.Name);

                if (inventoryItem != null)
                {
                    inventoryItem.Add(item.Quantity);
                }
                else
                {
                    Inventory.Add(item.Clone(item.Quantity));
                }
            } else
            {
                Inventory.Add(item.Clone());
            }
        }

        // 장비 장착 (0-based)
        public bool EquipAtIndex(int inventoryIndex)
        {
            if (inventoryIndex < 0 || inventoryIndex >= Inventory.Count) return false;

            Item item = Inventory[inventoryIndex];

            if (item.Type != ItemType.Equipment) return false;

            AttackPower += item.AttackBonus;
            Defense += item.DefenseBonus;
            item.IsEquipped = true;
            EquippedItems.Add(item);

            return true;
        }

        // 장비 해제 (0-based)
        public bool UnequipAtIndex(int inventoryIndex)
        {
            if (inventoryIndex < 0 || inventoryIndex >= Inventory.Count) return false;

            Item item = Inventory[inventoryIndex];

            if (item.Type != ItemType.Equipment || !item.IsEquipped) return false;

            AttackPower -= item.AttackBonus;
            Defense -= item.DefenseBonus;
            item.IsEquipped = false;
            EquippedItems.Remove(item);

            return true;
        }

        private void ShowLevelUp()
        {
            int addHP = 0, addMP = 0, addAttackPower = 0, addDefense = 0;

            switch (Job)
            {
                case JobType.Warrior:
                    addHP = 20;
                    addMP = 10;
                    addAttackPower = 5;
                    addDefense = 2;
                    break;

                case JobType.Mage:
                    addHP = 10;
                    addMP = 20;
                    addAttackPower = 7;
                    addDefense = 1;
                    break;

                case JobType.Rogue:
                    addHP = 15;
                    addMP = 15;
                    addAttackPower = 4;
                    addDefense = 1;
                    break;
            }

            // 레벨업 메시지 출력
            Console.WriteLine($"레벨: Lv{Level}  →  Lv{++Level}\n");

            void PrintStat(string name, string oldStr, string newStr)
            {
                Console.Write($"{name.PadRight(8)}: ");
                Console.Write($"{oldStr} ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("→ ");
                Console.Write($"{newStr}");
                Console.ResetColor();
                Console.WriteLine();
            }

            PrintStat("최대체력", $"{MaxHP}", $"{MaxHP += addHP}");
            PrintStat("최대마나", $"{MaxMP}", $"{MaxMP += addMP}");
            PrintStat("공격력", $"{AttackPower}", $"{AttackPower += addAttackPower}");
            PrintStat("방어력", $"{Defense}", $"{Defense += addDefense}");

            HP = MaxHP;
            MP = MaxMP;

            Console.WriteLine("────────────────────────────");
        }

        private void DisplayCreateCharacter(string message)
        {
            Console.Clear();
            Console.WriteLine("────────────────────────────");
            Console.WriteLine(message.PadLeft(15));
            Console.WriteLine("────────────────────────────\n");
        }

        private void DisplayStatDistribution()
        {
            string[] statsStr = { "체력", "마나", "공격력", "방어력", "공격속도" };
            int[] stats = { MaxHP, MaxMP, AttackPower, Defense, (int)AttackSpeed };
            int prevCursorTop = Console.GetCursorPosition().Top;

            Console.SetCursorPosition(0, prevCursorTop + 2);

            for (int i = 0; i < stats.Length; i++)
            {
                // 출력 예시
                //체력:     ▇▇▇▇▇▇▇▇□□ 8 * 10 = 80
                //마나:     ▇▇□□□□□□□□ 2 * 10 = 20
                //공격력:   ▇▇▇▇□□□□□□□ 4
                //방어력:   ▇▇▇▇▇□□□□□ 5
                //공격속도: ▇▇▇□□□□□□□ 3 * 50 = 150 / 1000 = 0.15
                string guage = new string('▇', stats[i]) + new string('□', 10 - stats[i]);

                Console.Write(statsStr[i].PadRight(8 - statsStr[i].Length) + ": ");
                Console.Write(guage + $" {stats[i]}");

                if (i == 0 || i == 1)
                {
                    Console.WriteLine($" * 10 = {stats[i] * 10}");
                }
                else if (i == 4)
                {
                    Console.WriteLine($" * 0.05 = {stats[i] * 0.05:F2}");
                }
                else
                {
                    Console.WriteLine();
                }
            }

            Console.SetCursorPosition(0, prevCursorTop);
        }

        private void RandomStats()
        {
            Random rand = new Random();
            int selectedStat;

            for (int i = 0; i < 10; i++)
            {
                selectedStat = rand.Next(0, 5);

                Action[] increments =
                {
                    () => MaxHP++,
                    () => MaxMP++,
                    () => AttackPower++,
                    () => Defense++,
                    () => AttackSpeed++
                };

                increments[selectedStat]();

                DisplayStatDistribution();

                MainGame.ShowAnimationMessage("🎲  능력치 분배중", 500, 100);
            }

            Console.WriteLine(" 분배 완료!");
            Console.ReadKey(true);
        }

        private void CreateCharacter()
        {
            bool isFailed, isBack;

            while (true)
            {
                isFailed = false;
                isBack = false;

                // 캐릭터 이름
                while (true)
                {
                    DisplayCreateCharacter("캐릭터 생성");

                    MainGame.ShowMessageAndReadInput(ConsoleColor.Black, "캐릭터 이름을 입력하세요", "올바른 이름을 입력해주세요", isFailed, out string input);

                    if (string.IsNullOrWhiteSpace(input))
                    {
                        isFailed = true;

                        continue;
                    }

                    Name = input;

                    break;
                }

                isFailed = false;

                // 캐릭터 직업
                while (true)
                {
                    DisplayCreateCharacter("캐릭터 생성");

                    MainGame.ShowMessageAndReadInput(ConsoleColor.Red,
                        "캐릭터 직업을 선택하세요\n" +
                        "1. ⚔️ 전사   (체력 50 마나 20 공격력 10 방어력 3 공격속도 1)\n" +
                        "2. 🔮 마법사 (체력 30 마나 50 공격력 20 공격속도 1.2)\n" +
                        "3. 🗡️ 도적   (체력 40 마나 30 공격력 8 공격속도 0.85)", "올바른 직업 번호를 입력해주세요", isFailed, out string input);

                    if (!int.TryParse(input, out int selected) || (selected < 1 || selected > 3))
                    {
                        isFailed = true;

                        continue;
                    }

                    Job = selected switch
                    {
                        1 => JobType.Warrior,
                        2 => JobType.Mage,
                        3 => JobType.Rogue,
                        _ => JobType.None,
                    };

                    break;
                }

                // 캐릭터 능력치 분배
                DisplayCreateCharacter("캐릭터 생성");
                RandomStats();

                MaxHP *= 10;
                MaxMP *= 10;
                HP = MaxHP;
                MP = MaxMP;
                AttackSpeed *= 0.05;

                int baseHP = 0, baseMP = 0, baseAttackPower = 0, baseDefense = 0;
                double baseAttackSpeed = 0;

                switch (Job)
                {
                    case JobType.Warrior:
                        baseHP = 50;
                        baseMP = 20;
                        baseAttackPower = 10;
                        baseDefense = 3;
                        baseAttackSpeed = 1d;
                        break;

                    case JobType.Mage:
                        baseHP = 30;
                        baseMP = 50;
                        baseAttackPower = 20;
                        baseAttackSpeed = 1.2d;
                        break;

                    case JobType.Rogue:
                        baseHP = 40;
                        baseMP = 30;
                        baseAttackPower = 8;
                        baseAttackSpeed = 0.85d;
                        break;
                }

                isFailed = false;

                // 캐릭터 생성 완료
                while (true)
                {
                    DisplayCreateCharacter("캐릭터 생성 완료");

                    MainGame.ShowMessageAndReadInput(ConsoleColor.Red,
                        $"이름: {Name}\n" +
                        $"직업: {JobName}\n\n" +
                        $"체력: {baseHP} + {HP} = {baseHP + HP}\n" +
                        $"마나: {baseMP} + {MP} = {baseMP + MP}\n" +
                        $"공격력: {baseAttackPower} + {AttackPower} = {baseAttackPower + AttackPower}\n" +
                        $"방어력: {baseDefense} + {Defense} = {baseDefense + Defense}\n" +
                        $"공격속도: {baseAttackSpeed} - {AttackSpeed:F2} = {baseAttackSpeed - AttackSpeed:F2}\n" +
                        "────────────────────────────\n" +
                        "1. 시작\n" +
                        "2. 처음으로", "올바른 숫자를 입력해주세요", isFailed, out string input);

                    if (!int.TryParse(input, out int selected) || (selected < 1 || selected > 2))
                    {
                        isFailed = true;

                        continue;
                    }

                    if (selected == 2)
                    {
                        isBack = true;

                        MaxHP = 0;
                        MaxMP = 0;
                        AttackPower = 0;
                        Defense = 0;
                        AttackSpeed = 0;
                    }

                    break;
                }

                if (isBack) continue;

                MaxHP = baseHP + MaxHP;
                MaxMP = baseMP + MaxMP;
                HP = MaxHP;
                MP = MaxMP;
                AttackPower += baseAttackPower;
                Defense += baseDefense;
                AttackSpeed = baseAttackSpeed - AttackSpeed;

                break;
            }
        }
    }
}
