using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG
{
    internal class MainGame
    {
        private Player player;

        public void Initialize()
        {
            player = new Player();
        }

        public void ShowMainTown()
        {
            bool isFailed;

            while (true)
            {
                isFailed = false;

                Console.Clear();

                Console.WriteLine("────────────────────────────");
                Console.WriteLine("        🏘️ 마을 입구".PadLeft(15));
                Console.WriteLine("────────────────────────────\n");

                // HUD 렌더링
                RenderHUD();

                Console.WriteLine("────────────────────────────");

                ShowMessageAndReadInput(ConsoleColor.Cyan,
                    "1. 🚶 사냥터\n" +
                    "2. 🏪 상점\n" +
                    "3. 🎒 인벤토리\n" +
                    "4. 🧾 상태창\n" +
                    "5. ❌ 게임 종료",
                    "올바른 숫자를 입력해주세요.", isFailed, out string input);

                if (!int.TryParse(input, out int selected) || selected < 1 || selected > 5)
                {
                    isFailed = true;
                    continue;
                }

                switch (selected)
                {
                    case 1: // 사냥터
                        ShowAnimationMessage("사냥터로 떠나는 중", 800, 120);
                        ShowHuntingGrounds();
                        break;

                    case 2: // 상점
                        ShowShop();
                        break;

                    case 3: // 인벤토리
                        ShowInventory();
                        break;

                    case 4: // 상태창
                        ShowStatus();
                        break;

                    case 5: // 게임 종료
                        Console.WriteLine("게임을 종료합니다...");
                        Thread.Sleep(500);
                        Environment.Exit(0);
                        break;
                }
            }
        }

        public static void ShowAnimationMessage(string message, int duration, int delay)
        {
            int dwTime = Environment.TickCount;
            int dotCount = 0;

            while (Environment.TickCount < dwTime + duration)
            {
                dotCount = (dotCount % 5) + 1;

                Console.Write($"\r{message + new string('.', dotCount) + new string(' ', 5 - dotCount)}");

                Thread.Sleep(delay);
            }
        }

        public static void ShowMessageAndReadInput(ConsoleColor color, string message, string failMessage, in bool isFailed, out string input)
        {
            if (color != ConsoleColor.Black)
            {
                for (int i = 0; i < message.Length; i++)
                {
                    if (Console.GetCursorPosition().Left == 0 &&
                        (message[i] >= '1' && message[i] <= '9') && message[i + 1] == '.')
                    {
                        Console.ForegroundColor = color;
                        Console.Write($"{message[i]}{message[i + 1]}");
                        Console.ResetColor();

                        i++;
                    }
                    else
                    {
                        Console.Write(message[i]);
                    }
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine(message);
            }

            if (isFailed)
            {
                Console.WriteLine($"\n{failMessage}");
            }

            Console.Write("> ");
            input = Console.ReadLine() ?? string.Empty;
        }

        // 사냥터
        private void ShowHuntingGrounds()
        {
            bool isFailed;

            while (true)
            {
                isFailed = false;

                Console.Clear();
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("        🌲 사냥터 선택".PadLeft(15));
                Console.WriteLine("────────────────────────────\n");

                ShowMessageAndReadInput(ConsoleColor.Cyan,
                    "1. 🟢 초원 (슬라임 Lv1)\n" +
                    "2. 🧌 동굴 (고블린 Lv3)\n" +
                    "3. 🔙 뒤로가기\n" +
                    "────────────────────────────", "올바른 숫자를 입력해주세요.", isFailed, out string input);

                if (!int.TryParse(input, out int selected) || selected < 1 || selected > 3)
                {
                    isFailed = true;
                    continue;
                }

                switch (selected)
                {
                    case 1: // 초원 (슬라임 Lv1)
                        var slime = new Monster("슬라임", 1, 30, 5, 1, 1.0d, 40, 120);

                        slime.AddDrop(() => new Item(
                            name: "💧 슬라임 점액",
                            description: "요리/연금용 재료.",
                            type: ItemType.Misc,
                            price: 10,
                            isStackable: true,
                            maxStack: 99),
                            chance: 0.7d, min: 1, max: 3);

                        StartBattle(slime);
                        break;

                    case 2: // 동굴 (고블린 Lv3)
                        var goblin = new Monster("고블린", 3, 50, 8, 2, 1.0d, 80, 240);

                        goblin.AddDrop(() => new Item(
                            name: "🗡️ 녹슨 단검",
                            description: "낡은 단검.",
                            type: ItemType.Equipment,
                            price: 100,
                            isStackable: false,
                            maxStack: 1,
                            attackBonus: 2,
                            slot: EquipmentSlotType.Weapon),
                            chance: 0.6d, min: 1, max: 1);

                        goblin.AddDrop(() => new Item(
                            name: "🛡️ 가죽 방패",
                            description: "가벼운 가죽 방패.",
                            type: ItemType.Equipment,
                            price: 100,
                            isStackable: false,
                            maxStack: 1,
                            defenseBonus: 2,
                            slot: EquipmentSlotType.Shield),
                            chance: 0.6d, min: 1, max: 1);

                        StartBattle(goblin);
                        break;

                    case 3: // 뒤로가기
                        return;
                }
            }
        }

        private void StartBattle(Monster monster)
        {
            int pInterval = (int)(player.AttackSpeed * 1000);
            int mInterval = (int)(monster.AttackSpeed * 1000);

            int nextP = Environment.TickCount + pInterval;
            int nextM = Environment.TickCount + mInterval;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("          ⚔️ 전투 중".PadLeft(15));
                Console.WriteLine("────────────────────────────\n");

                // 전투 HUD
                RenderBattleHUD(monster);

                Console.WriteLine("────────────────────────────");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("1.");
                Console.ResetColor();
                Console.WriteLine(" 도망");
                Console.Write("> ");

                int target = Math.Min(nextP, nextM);

                while (Environment.TickCount < target)
                {
                    if (Console.KeyAvailable)
                    {
                        ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                        // 도망
                        if (keyInfo.KeyChar == '1')
                        {
                            ShowAnimationMessage("도망치는 중", 600, 100);
                            return;
                        }
                    }

                    Thread.Sleep(10);
                }

                int now = Environment.TickCount;

                while (nextP <= now || nextM <= now)
                {
                    // 플레이어 공격
                    if (nextP <= nextM)
                    {
                        player.Attack(monster);

                        if (monster.HP <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("────────────────────────────");
                            Console.WriteLine("         🏆 전투 승리!".PadLeft(15));
                            Console.WriteLine("────────────────────────────\n");
                            Console.WriteLine($"{monster.Name}을(를) 처치했습니다!\n");
                            Console.WriteLine($"경험치 {monster.ExpReward} Exp 획득!");
                            Console.WriteLine($"골드 {monster.GoldReward} Gold 획득!");

                            var drops = monster.GetDrops();

                            if (drops != null && drops.Count > 0)
                            {
                                Console.WriteLine("획득 아이템");

                                foreach (var item in drops)
                                {
                                    player.AddItem(item);

                                    string quantityText = item.IsStackable ? $" x{item.Quantity}" : string.Empty;

                                    Console.WriteLine($" - {item.Name}{quantityText}");
                                }
                            }
                            else
                            {
                                Console.WriteLine("획득 아이템 없음");
                            }

                            Console.WriteLine();

                            player.Exp += monster.ExpReward;
                            player.Gold += monster.GoldReward;

                            Console.WriteLine("\n계속하려면 아무 키나 누르세요...");
                            Console.ReadKey(true);

                            return;
                        }

                        nextP += pInterval;
                    }
                    // 몬스터 공격
                    else
                    {
                        monster.Attack(player);

                        if (player.HP <= 0)
                        {
                            Console.Clear();
                            Console.WriteLine("────────────────────────────");
                            Console.WriteLine("         💀 전투 패배...".PadLeft(15));
                            Console.WriteLine("────────────────────────────\n");
                            Console.WriteLine("플레이어가 쓰러졌습니다...\n");
                            Console.WriteLine("계속하려면 아무 키나 누르세요...");
                            Console.ReadKey(true);

                            player.HP = 1;
                            return;
                        }

                        nextM += mInterval;
                    }
                }
            }
        }

        private void RenderBattleHUD(Monster monster)
        {
            Console.WriteLine($"플레이어: {player.Name} ({player.JobName})   Lv{player.Level}");
            Console.Write("HP: ");
            DrawBar(player.HP, player.MaxHP, 10, ConsoleColor.Red);
            Console.WriteLine($"  {player.HP}/{player.MaxHP}    ");

            Console.Write("MP: ");
            DrawBar(player.MP, player.MaxMP, 10, ConsoleColor.Blue);
            Console.WriteLine($"  {player.MP}/{player.MaxMP}\n");
            Console.WriteLine($"공격력: {player.AttackPower}   방어력: {player.Defense}   공격속도: {player.AttackSpeed:F2}\n");

            Console.WriteLine($"몬스터: {monster.Name}   Lv{monster.Level}");
            Console.Write("HP: ");
            DrawBar(monster.HP, monster.MaxHP, 10, ConsoleColor.Red);
            Console.WriteLine($"  {monster.HP}/{monster.MaxHP}\n");
            Console.WriteLine($"공격력: {monster.AttackPower}   방어력: {monster.Defense}   공격속도: {monster.AttackSpeed:F2}");
        }

        private void ShowShop()
        {
            var shop = new List<Item>
            {
                new Item(
                    name: "🧴 체력 포션",
                    description: "HP를 50 회복합니다.",
                    type: ItemType.Consumable,
                    price: 50,
                    isStackable: true,
                    maxStack: 99,
                    useEffect: (Unit user) =>
                    {
                        int healAmount = 50;
                        user.HP = Math.Min(user.MaxHP, user.HP + healAmount);
                    }),

                new Item(
                    name: "🧪 마나 포션",
                    description: "MP를 30 회복합니다.",
                    type: ItemType.Consumable,
                    price: 60,
                    isStackable: true,
                    maxStack: 99,
                    useEffect: (Unit user) =>
                    {
                        int healAmount = 30;
                        user.MP = Math.Min(user.MaxMP, user.MP + healAmount);
                    }),

                new Item(
                    name: "🗡️ 철검",
                    description: "기본적인 철제 검.",
                    type: ItemType.Equipment,
                    price: 200,
                    isStackable: false,
                    maxStack: 1,
                    attackBonus: 5,
                    slot: EquipmentSlotType.Weapon),

                new Item(
                    name: "🛡️ 철방패",
                    description: "기본적인 철제 방패.",
                    type: ItemType.Equipment,
                    price: 200,
                    isStackable: false,
                    maxStack: 1,
                    defenseBonus: 5,
                    slot: EquipmentSlotType.Shield),
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("          🏪 상점".PadLeft(15));
                Console.WriteLine("────────────────────────────\n");

                Console.WriteLine("판매 아이템:");

                for (int i = 0; i < shop.Count; i++)
                {
                    var item = shop[i];

                    Console.WriteLine($" {i + 1}. {item.Name.PadRight(16 - item.Name.Length)}  - {item.Description.PadRight(18 - item.Description.Length)}" + $"{item.Price}G".PadLeft(12));
                }

                Console.WriteLine("\n내 아이템 (판매 가격 = 구매가 50%):");

                if (player.Inventory.Count == 0)
                {
                    Console.WriteLine(" (없음)");
                }
                else
                {
                    for (int i = 0; i < player.Inventory.Count; i++)
                    {
                        var item = player.Inventory[i];
                        string quantity = item.IsStackable ? $" x{item.Quantity}" : string.Empty;
                        string isEquipped = item.IsEquipped ? " (장착 중)" : string.Empty;

                        Console.WriteLine($" {i + 1}. {item.Name}{quantity}{isEquipped}  - {item.Description}  {item.Price / 2}G");
                    }
                }

                Console.WriteLine($"\n💰 골드: {player.Gold} Gold");
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("명령: B숫자 → 구매, S숫자 → 판매(내 인벤토리 번호), 0 → 뒤로");
                Console.Write("> ");

                string input = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(input)) continue;

                if (input == "0") return;

                if ((input.StartsWith("B") || input.StartsWith("b")) && int.TryParse(input.Substring(1), out int buyIndex))
                {
                    if (buyIndex < 1 || buyIndex > shop.Count)
                    {
                        Console.WriteLine("\n잘못된 번호입니다");
                        Console.ReadKey(true);
                        continue;
                    }

                    var item = shop[buyIndex - 1];

                    if (item.IsStackable)
                    {
                        Console.WriteLine($"\n몇 개 구매하시겠습니까? (최대 {item.MaxStack}개): ");

                        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 1 || quantity > item.MaxStack)
                        {
                            Console.WriteLine("\n잘못된 수량입니다");
                            Console.ReadKey(true);
                            continue;
                        }

                        int totalPrice = item.Price * quantity;

                        if (player.Gold < totalPrice)
                        {
                            Console.WriteLine("\n골드가 부족합니다");
                            Console.ReadKey(true);
                            continue;
                        }

                        player.Gold -= totalPrice;
                        player.AddItem(item.Clone(quantity));

                        Console.WriteLine($"\n{item.Name} x{quantity}개 구매했습니다");
                    }
                    else
                    {
                        if (player.Gold < item.Price)
                        {
                            Console.WriteLine("\n골드가 부족합니다");
                            Console.ReadKey(true);
                            continue;
                        }

                        player.Gold -= item.Price;
                        player.AddItem(item.Clone());

                        Console.WriteLine($"\n{item.Name}을(를) 구매했습니다");
                    }

                    Console.ReadKey(true);
                    continue;
                }
                else if ((input.StartsWith("S") || input.StartsWith("s")) && int.TryParse(input.Substring(1), out int sellIndex))
                {
                    if (sellIndex < 1 || sellIndex > player.Inventory.Count)
                    {
                        Console.WriteLine("\n잘못된 번호입니다");
                        Console.ReadKey(true);
                        continue;
                    }

                    var item = player.Inventory[sellIndex - 1];

                    if(item.IsEquipped)
                    {
                        Console.WriteLine("\n장착 중인 아이템은 판매할 수 없습니다");
                        Console.ReadKey(true);
                        continue;
                    }

                    if (item.IsStackable)
                    {
                        Console.WriteLine($"\n몇 개 판매하시겠습니까? (최대 {item.Quantity}개): ");

                        if (!int.TryParse(Console.ReadLine(), out int quantity) || quantity < 1 || quantity > item.Quantity)
                        {
                            Console.WriteLine("\n잘못된 수량입니다");
                            Console.ReadKey(true);
                            continue;
                        }

                        int totalPrice = (item.Price / 2) * quantity;

                        Console.WriteLine($"\n'{item.Name}' x{quantity}개 판매하시겠습니까? (판매가: {totalPrice}G) Y/N");

                        var key = Console.ReadKey(true);

                        if (key.Key == ConsoleKey.Y)
                        {
                            if (quantity == item.Quantity)
                            {
                                player.Inventory.RemoveAt(sellIndex - 1);
                            }
                            else
                            {
                                item.Add(-quantity);
                            }

                            player.Gold += totalPrice;

                            Console.WriteLine($"\n판매 완료. 골드 +{totalPrice}G");
                        }
                        else
                        {
                            Console.WriteLine("\n취소되었습니다");
                        }

                        Console.ReadKey(true);
                        continue;
                    }
                    else
                    {
                        Console.WriteLine($"\n'{item.Name}'을(를) 판매하시겠습니까? (판매가: {item.Price / 2}G) Y/N");

                        var key = Console.ReadKey(true);

                        if (key.Key == ConsoleKey.Y)
                        {
                            player.Inventory.RemoveAt(sellIndex - 1);
                            player.Gold += item.Price / 2;
                            Console.WriteLine($"\n판매 완료. 골드 +{item.Price / 2}G");
                        }
                        else
                        {
                            Console.WriteLine("\n취소되었습니다");
                        }

                        Console.ReadKey(true);
                        continue;
                    }
                }
            }
        }

        private void ShowInventory()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("         🎒 인벤토리".PadLeft(15));
                Console.WriteLine("────────────────────────────\n");

                for (int i = 0; i < player.Inventory.Count; i++)
                {
                    var item = player.Inventory[i];

                    string quantity = item.IsStackable ? $" x{item.Quantity}" : string.Empty;
                    string equip = item.IsEquipped ? " (장착 중)" : string.Empty;
                    string type = item.Type == ItemType.Equipment ? "(장비)" :
                                   item.Type == ItemType.Consumable ? "(소모품)" : "(기타)";
                    string attackBonusText = item.AttackBonus > 0 ? $" 공격력 +{item.AttackBonus}" : string.Empty;
                    string defenseBonusText = item.DefenseBonus > 0 ? $" 방어력 +{item.DefenseBonus}" : string.Empty;

                    Console.WriteLine($" {i + 1}. {item.Name}{quantity}{equip}    {type}{attackBonusText}{defenseBonusText}");

                    if (!string.IsNullOrWhiteSpace(item.Description))
                    {
                        Console.WriteLine($"    - {item.Description}");
                    }
                }

                Console.WriteLine();
                Console.WriteLine($"💰 골드: {player.Gold} Gold");
                Console.WriteLine("────────────────────────────");
                Console.WriteLine("명령: 숫자 → 사용 | 0 → 뒤로");
                Console.Write("> ");

                string input = Console.ReadLine() ?? string.Empty;

                if (string.IsNullOrWhiteSpace(input)) continue;

                if (input == "0") return;

                if (!int.TryParse(input, out int selected) || selected < 1 || selected > player.Inventory.Count) continue;

                var selectedItem = player.Inventory[selected - 1];

                if (selectedItem.Type == ItemType.Equipment)
                {
                    if (!selectedItem.IsEquipped)
                    {
                        var equalSlotItem = player.EquippedItems.FirstOrDefault(i => i.Slot == selectedItem.Slot);

                        if (equalSlotItem != null)
                        {
                            int index = player.Inventory.IndexOf(equalSlotItem);

                            if (index >= 0)
                            {
                                player.UnequipAtIndex(index);
                                Console.WriteLine($"\n기존 {equalSlotItem.Name}을(를) 해제합니다");
                            }
                        }

                        if (player.EquipAtIndex(selected - 1))
                        {
                            Console.WriteLine($"\n{selectedItem.Name}을(를) 장착했습니다");
                        }
                    }
                    else
                    {
                        if (player.UnequipAtIndex(selected - 1))
                        {
                            Console.WriteLine($"\n{selectedItem.Name}을(를) 해제했습니다");
                        }
                    }

                    Console.ReadKey(true);

                    continue;
                }
                else
                {
                    if (selectedItem.Use(player))
                    {
                        Console.WriteLine($"\n{selectedItem.Name}을(를) 사용했습니다");

                        if (selectedItem.Quantity <= 0)
                        {
                            player.Inventory.RemoveAt(selected - 1);
                        }
                    }
                    else
                    {
                        Console.WriteLine($"\n{selectedItem.Name}은(는) 사용할 수 없는 아이템입니다");
                    }
                }

                Console.ReadKey(true);
            }
        }

        private void ShowStatus()
        {
            Console.Clear();
            Console.WriteLine("────────────────────────────");
            Console.WriteLine("          🧾 상태창".PadLeft(15));
            Console.WriteLine("────────────────────────────\n");

            // 기본 정보
            Console.WriteLine($"이름: {player.Name}   {player.JobName}   Lv{player.Level}");
            Console.WriteLine($"경험치:  {player.Exp} / {player.NeedExp}\n");

            // HP / MP 바
            Console.Write("HP: ");
            DrawBar(player.HP, player.MaxHP, 10, ConsoleColor.Red);
            Console.WriteLine($"  {player.HP}/{player.MaxHP}");

            Console.Write("MP: ");
            DrawBar(player.MP, player.MaxMP, 10, ConsoleColor.Blue);
            Console.WriteLine($"  {player.MP}/{player.MaxMP}\n");

            // 장비 보너스 합계 계산 (EquippedItems가 유지되어 있다고 가정)
            int equipAtkBonus = player.EquippedItems?.Sum(i => i.AttackBonus) ?? 0;
            int equipDefBonus = player.EquippedItems?.Sum(i => i.DefenseBonus) ?? 0;

            int baseAtk = Math.Max(0, player.AttackPower - equipAtkBonus);
            int baseDef = Math.Max(0, player.Defense - equipDefBonus);

            Console.WriteLine($"공격력: {player.AttackPower}   (기본: {baseAtk}  장비: +{equipAtkBonus})");
            Console.WriteLine($"방어력: {player.Defense}   (기본: {baseDef}  장비: +{equipDefBonus})");
            Console.WriteLine($"공격속도: {player.AttackSpeed:F2}\n");

            // 장착 아이템 목록
            Console.WriteLine("장착중:");
            if (player.EquippedItems == null || player.EquippedItems.Count == 0)
            {
                Console.WriteLine(" (없음)\n");
            }
            else
            {
                for (int i = 0; i < player.EquippedItems.Count; i++)
                {
                    var equip = player.EquippedItems[i];
                    string attackBonus = equip.AttackBonus != 0 ? $" 공격력 +{equip.AttackBonus}" : string.Empty;
                    string defenseBonus = equip.DefenseBonus != 0 ? $" 방어력 +{equip.DefenseBonus}" : string.Empty;

                    Console.WriteLine($" - {i + 1}. {equip.Name}   {attackBonus}{defenseBonus}");
                }

                Console.WriteLine();
            }

            // 인벤토리/골드 요약
            Console.WriteLine($"인벤토리: {player.Inventory.Count}개");
            Console.WriteLine($"💰 골드: {player.Gold} Gold");
            Console.WriteLine("────────────────────────────");
            Console.ReadKey(true);
        }

        private void RenderHUD()
        {
            Console.WriteLine($"이름: {player.Name} ({player.JobName})     레벨: {player.Level}   경험치: {player.Exp}/{player.NeedExp}");

            // 체력바
            Console.Write("HP: ");
            DrawBar(player.HP, player.MaxHP, 10, ConsoleColor.Red);
            Console.Write($"  {player.HP}/{player.MaxHP}    ");

            // 마력바
            Console.Write("MP: ");
            DrawBar(player.MP, player.MaxMP, 10, ConsoleColor.Blue);
            Console.WriteLine($"  {player.MP}/{player.MaxMP}");

            Console.WriteLine($"💰 골드: {player.Gold} Gold");
        }

        private void DrawBar(int value, int max, int width, ConsoleColor color)
        {
            int fill = (max <= 0) ? 0 : (int)Math.Round((double)value / max * width);

            fill = Math.Clamp(fill, 0, width);

            int empty = width - fill;

            ConsoleColor prevColor = Console.ForegroundColor;

            Console.ForegroundColor = color;
            Console.Write(new string('█', fill));
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.Write(new string('□', empty));
            Console.ForegroundColor = prevColor;
        }
    }
}