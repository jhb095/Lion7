using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 캐릭터 스탯 계산
            //int baseAttack = 50;
            //int weaponDamage = 30;
            //int totalAttack = baseAttack + weaponDamage;

            //Console.WriteLine("=== 공격력 계산 ===");
            //Console.WriteLine($"기본 공격력: {baseAttack}");
            //Console.WriteLine($"무기 데미지: {weaponDamage}");
            //Console.WriteLine($"총 공격력: {totalAttack}");

            //// 데미지 계산
            //int playerHealth = 100;
            //int damage = 25;

            //playerHealth -= damage;

            //Console.WriteLine("\n=== 데미지 계산 ===");
            //Console.WriteLine($"받은 데미지: {damage}");
            //Console.WriteLine($"남은 체력: {playerHealth}");

            //// 경험치 계산
            //int monsterKilled = 5;
            //int expPerMonster = 100;
            //int totalExp = monsterKilled * expPerMonster;

            //Console.WriteLine("\n=== 경험치 계산 ===");
            //Console.WriteLine($"처치한 몬스터 수: {monsterKilled}");
            //Console.WriteLine($"몬스터당 경험치: {expPerMonster}");
            //Console.WriteLine($"총 경험치: {totalExp}");

            //// 아이템 분배
            //int totalGold = 1000;
            //int playerCount = 4;
            //int goldPerPlayer = totalGold / playerCount;
            //int remainingGold = totalGold % playerCount;

            //Console.WriteLine("\n=== 골드 분배 ===");
            //Console.WriteLine($"총 골드: {totalGold}");
            //Console.WriteLine($"플레이어 수: {playerCount}");
            //Console.WriteLine($"플레이어당 골드: {goldPerPlayer}");
            //Console.WriteLine($"남은 골드: {remainingGold}");


            // 증감 연산자 ++ --
            //int b = 3;

            //b++;

            //Console.WriteLine(b);

            //--b;

            //Console.WriteLine(b);

            // 전위 후위 증가 중요
            //int count = 5;

            //Console.WriteLine(count++);


            //int killCount = 0;
            //int remainingBullet = 30;
            //int countdown = 3;

            //Console.WriteLine("=== 몬스터 처치 ===");
            //Console.WriteLine($"고블린 처치!(킬 카운트: {++killCount})");
            //Console.WriteLine($"오크 처치!(킬 카운트: {++killCount})");
            //Console.WriteLine($"드래곤 처치!(킬 카운트: {++killCount})");
            //Console.WriteLine($"총 처치 수: {killCount}마리");

            //Console.WriteLine("\n=== 사격 ===");
            //Console.WriteLine($"남은 탄약: {remainingBullet}");
            //Console.WriteLine($"발사! 남은 탄약: {--remainingBullet}");
            //Console.WriteLine($"발사! 남은 탄약: {--remainingBullet}");
            //Console.WriteLine($"발사! 남은 탄약: {--remainingBullet}");

            //Console.WriteLine("\n=== 카운트 다운 ===");
            //Console.WriteLine(countdown--);
            //Console.WriteLine(countdown--);
            //Console.WriteLine(countdown--);
            //Console.WriteLine("발사!");


            //// 관계형 연산자
            //int x = 5, y = 10;

            //Console.WriteLine(x < y);
            //Console.WriteLine(x > y);
            //Console.WriteLine(x <= y);
            //Console.WriteLine(x >= y);
            //Console.WriteLine(x == y);
            //Console.WriteLine(x != y);


            // 논리 연산자
            //// AND
            //bool a = true, b = true;

            //Console.WriteLine(a && b);
            //a = false; b = true;
            //Console.WriteLine(a && b);
            //a = true; b = false;
            //Console.WriteLine(a && b);
            //a = false; b = false;
            //Console.WriteLine(a && b);


            //// OR
            //bool a = false, b = false;

            //Console.WriteLine(a || b);
            //a = false; b = true;
            //Console.WriteLine(a || b);
            //a = true; b = false;
            //Console.WriteLine(a || b);
            //a = true; b = true;
            //Console.WriteLine(a || b);


            //// 논리 NOT
            //bool a = false;

            //Console.WriteLine(!a);


            //int x = 5;  // 0101
            //int y = 3;  // 0011

            //Console.WriteLine($"8비트: {Convert.ToString(x & y, 2).PadLeft(8, '0')}");
            //Console.WriteLine($"8비트: {Convert.ToString(x | y, 2).PadLeft(8, '0')}");
            //Console.WriteLine($"8비트: {Convert.ToString(x ^ y, 2).PadLeft(8, '0')}");
            //Console.WriteLine($"32비트: {Convert.ToString(~x, 2)}");


            //int value = 4;  // 0100
            //string binary = Convert.ToString(value << 1, 2).PadLeft(8, '0');

            //Console.WriteLine(binary);

            //binary = Convert.ToString(value >> 1, 2).PadLeft(8, '0');
            //Console.WriteLine(binary);


            //int inventory = 0;  // 0000 0000

            //Console.WriteLine($"초기 인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //// 슬롯 번호
            //int slot1 = 1;  // 활
            //int slot2 = 2;  // 지팡이

            //// 슬롯 0에 활을 추가
            //inventory |= 1 << slot1;
            //Console.WriteLine($"슬롯 {slot1}에 활 추가");
            //Console.WriteLine($"인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");

            //// 슬롯 2에 지팡이를 추가
            //inventory |= 1 << slot2;
            //Console.WriteLine($"슬롯 {slot2}에 지팡이 추가");
            //Console.WriteLine($"인벤토리: {Convert.ToString(inventory, 2).PadLeft(8, '0')}");


            // 문제1
            int currentHP = 80;
            int maxHP = 100;

            Console.WriteLine($"초기 체력: {currentHP}/{maxHP}");

            currentHP -= 25;
            Console.WriteLine($"데미지 -25: {currentHP}/{maxHP}");

            currentHP += 30;
            Console.WriteLine($"회복 +30: {currentHP}/{maxHP}");

            currentHP -= 5;
            Console.WriteLine($"독 데미지 -5: {currentHP}/{maxHP}\n");


            // 문제2
            int killedMonsters = 3;
            int expPerMonster = 150;
            int needExpForLevelUp = 500;
            int gainedExp = killedMonsters * expPerMonster;

            Console.WriteLine($"처치한 몬스터: {killedMonsters}마리");
            Console.WriteLine($"획득 경험치: {gainedExp}");
            Console.WriteLine($"레벨업까지 필요: {needExpForLevelUp - gainedExp}\n");


            // 문제3
            int gainedGold = 1234;
            int partyMembers = 5;

            Console.WriteLine($"총 골드: {gainedGold}");
            Console.WriteLine($"파티원: {partyMembers}명");
            Console.WriteLine($"1인당 골드: {gainedGold / partyMembers}");
            Console.WriteLine($"남은 골드: {gainedGold % partyMembers}\n");


            // 문제4
            int playerLevel = 35;
            int requiredLevel = 30;
            bool hasKey = true;
            int playerCurrentHP = 60;
            int playerMaxHP = 100;
            bool passLevel, passHP;

            passLevel = playerLevel >= requiredLevel;
            passHP = (float)playerCurrentHP / playerMaxHP >= 0.5f;

            Console.WriteLine("=== 던전 입장 조건 ===");
            Console.WriteLine($"레벨 조건 ({requiredLevel} 이상): {passLevel}");
            Console.WriteLine($"열쇠 보유: {hasKey}");
            Console.WriteLine($"체력 조건 (50% 이상): {passHP}");
            Console.WriteLine($"입장 가능: {passLevel && hasKey && passHP}\n");


            // 문제5
            int itemPrice = 5000;
            bool isVIP = true;
            bool hasCoupon = true;
            int discountPrice = isVIP ? (int)(itemPrice * 0.8f) : itemPrice;
            
            Console.WriteLine($"원가: {itemPrice}골드");
            Console.WriteLine($"VIP 할인 (20%): {discountPrice}골드");

            discountPrice = hasCoupon ? discountPrice - 500 : discountPrice;

            Console.WriteLine($"쿠폰 할인 (-500): {discountPrice}골드");
            Console.WriteLine($"최종 가격: {discountPrice}골드");
        }
    }
}
