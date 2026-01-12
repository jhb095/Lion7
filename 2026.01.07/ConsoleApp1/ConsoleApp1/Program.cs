using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a = 10, b = 20;
            //int max = (a > b) ? a : b;   // 삼항 연산자

            //Console.WriteLine(max);


            //// 삼항 연산자
            //// 조건 ? 참 : 거짓
            //int score = 85;
            //string result = (score >= 60) ? "합격" : "불합격";

            //Console.WriteLine("=== 시험 결과 ===");
            //Console.WriteLine("점수: " + score);
            //Console.WriteLine("결과: " + result);


            //// 예제 2: 레벨에 따른 등급
            //// 레벨 45
            //// 50보다크면 고급 30~50 사이면 중급 그렇지 않으면 초급
            //int level = 45;
            //string grade = (level > 50) ? "고급" : (level >= 30) ? "중급" : "초급";

            //Console.WriteLine("플레이어 등급");
            //Console.WriteLine($"레벨: {level}" );
            //Console.Write($"등급: {grade}");


            //int health = 30;
            //int maxHealth = 100;
            //string healthStatus = (health >= maxHealth * 0.7) ? "안전" :
            //                      (health >= maxHealth * 0.3) ? "주의" : "위험";

            //Console.WriteLine("=== 체력 상태 ===");
            //Console.WriteLine(healthStatus);


            //// 연산자 우선순위
            //int result = 10 + 2 * 5;

            //Console.WriteLine(result);

            //int adjustedResult = (10 + 2) * 5;

            //Console.WriteLine(adjustedResult);


            //// 예제 2: 데미지 계산
            //int baseDamage = 50;
            //int bonusDamage = 20;
            //double criticalMultiplier = 1.5;

            //// 잘못된 계산
            //double damage1 = baseDamage + bonusDamage * criticalMultiplier;
            //// 올바른 계산
            //double damage2 = (baseDamage + bonusDamage) * criticalMultiplier;

            //Console.WriteLine("\n=== 크리티컬 데미지 계산 ===");
            //Console.WriteLine($"기본 데미지: {baseDamage}");
            //Console.WriteLine($"보너스 데미지: {bonusDamage}");
            //Console.WriteLine($"크리티컬 배율: {criticalMultiplier}");
            //Console.WriteLine($"잘못된 계산: {damage1}");  // 80.0
            //Console.WriteLine($"올바른 계산: {damage2}");  // 105.0


            //int health = 30;
            //int maxHealth = 100;
            //int enemyDistance = 5;
            //int attackRange = 3;

            //Console.WriteLine($"현재 체력: {health}/{maxHealth}");

            //if (health == 0)
            //{
            //    Console.WriteLine("게임 오버!\n부활 지점에서 다시 시작합니다.");
            //}
            //else if (health <= maxHealth * 0.3f)
            //{
            //    Console.WriteLine("경고: 체력이 위험합니다!\n회복 아이템을 사용하세요!");
            //}

            //if (health <= maxHealth * 0.5f)
            //{
            //    Console.WriteLine("체력이 50% 이하입니다\n");
            //}

            //if (enemyDistance <= attackRange)
            //{
            //    Console.WriteLine("적이 사거리 안에 있습니다!");
            //    Console.WriteLine("공격 가능!");
            //}
            //else
            //{
            //    Console.WriteLine("적이 사거리 밖에 있습니다!");
            //}


            //// 아이템 구매 시스템
            //int playerGold = 500;
            //int itemPrice = 250;
            //string itemName = "강철 검";

            //Console.WriteLine("=== 상점 ===");
            //Console.WriteLine($"아이템 : {itemName}");
            //Console.WriteLine($"가격 : {itemPrice}골드");
            //Console.WriteLine($"소지금 : {playerGold}골드");
            //Console.WriteLine();

            //if(playerGold >= itemPrice)
            //{
            //    playerGold -= itemPrice;

            //    Console.WriteLine("구매 성공!");
            //    Console.WriteLine($"{itemName}을 획득했습니다.");
            //    Console.WriteLine($"남은 골드: {playerGold}");
            //} else
            //{
            //    int needGold = itemPrice - playerGold;

            //    Console.WriteLine("골드가 부족합니다!");
            //    Console.WriteLine($"필요한 골드: {needGold}골드 더 필요");
            //}


            //int playerLevel = 48;
            //int requiredLevel = 50;

            //Console.WriteLine("=== 던전 입장 ===");

            //if (playerLevel >= requiredLevel)
            //{
            //    Console.WriteLine("던전에 입장합니다.!");
            //    Console.WriteLine("전투 준비!");
            //}
            //else
            //{
            //    Console.WriteLine("레벨이 부족합니다!");
            //    Console.WriteLine($"필요 레벨 : {requiredLevel}");
            //    Console.WriteLine($"현재 레벨 : {playerLevel}");
            //    Console.WriteLine($"레벨업이 필요합니다: {requiredLevel - playerLevel}레벨");
            //}


            // 캐릭터 선택화면을 switch로 만드시오
            // 1: 전사, 2: 마법사, 3: 궁수, 4: 도적

            Console.OutputEncoding = Encoding.UTF8;

            //int jobChoice = 2;
            //string job = string.Empty;
            //string trait = string.Empty;
            //string weapon = string.Empty;
            //string stats = string.Empty;

            //Console.WriteLine("=== 캐릭터 생성 ===");

            //switch(jobChoice)
            //{
            //    case 1:
            //        job = "전사";
            //        trait = "탱커";
            //        weapon = "검";
            //        stats = "힘 + 20";

            //        break;

            //    case 2:
            //        job = "🔮 마법사";
            //        trait = "강력한 마법 공격";
            //        weapon = "지팡이, 마법서";
            //        stats = "마나 + 100, 마법력 + 20";

            //        break;

            //    case 3:
            //        job = "궁수";
            //        trait = "원거리 딜러";
            //        weapon = "활";
            //        stats = "민첩 + 20";

            //        break;

            //    case 4:
            //        job = "도적";
            //        trait = "근거리 딜러";
            //        weapon = "단검";
            //        stats = "민첩 + 20";

            //        break;
            //}

            //Console.WriteLine($"직업: {job}");
            //Console.WriteLine($"특성: {trait}");
            //Console.WriteLine($"주 무기: {weapon}");
            //Console.WriteLine($"스탯: {stats}");


            //int i = 1;

            //Console.WriteLine("=== 몬스터 웨이브 시작 ===");

            //for(; i <= 5; i++)
            //{
            //    Console.WriteLine($"👹 고블린 #{i} 생성!");
            //}

            //Console.WriteLine($"총 {i-1}마리 생성 완료!");


            //Console.WriteLine("=== 게임 시작 카운트다운 ===");

            //for(int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine($"{i}...");
            //}

            //Console.WriteLine("🎮 게임 시작!");


            // 검 종류
            // 무한의 대검 10%
            // 카타나 20%
            // 엑스칼리버 30%
            // 정기점검 40%

            //Random rand = new Random();
            //string sword;
            //int random;

            //Console.WriteLine("당신은 20번뽑기가 가능합니다. 지금 실행합니다.");

            //for(int i = 0; i < 20; i++)
            //{
            //    random = rand.Next(1, 101);

            //    if (random > 90) sword = "무한의 대검";
            //    else if (random > 70) sword = "카타나";
            //    else if (random > 40) sword = "엑스칼리버";
            //    else sword = "정기점검";

            //    Console.WriteLine(sword);
            //    Thread.Sleep(500);
            //}

            int temperature;

            Console.Write("온도: ");

            temperature = int.Parse(Console.ReadLine());

            Console.WriteLine($"현재 온도: {temperature}℃");

            if (temperature < 0) Console.WriteLine("매우 추워요! 패딩과 목도리가 필요해요.");
            else if (temperature < 10) Console.WriteLine("추워요! 코트를 입으세요.");
            else if (temperature < 20) Console.WriteLine("쌀쌀해요! 가디건이나 자켓을 챙기세요.");
            else if (temperature < 30) Console.WriteLine("적당해요! 긴팔 티셔츠를 입으세요.");
            else Console.WriteLine("매우 더워요! 반팔과 반바지를 입으세요.");

            Console.WriteLine();

            int jobChoice;
            string job = string.Empty;
            string trait = string.Empty;
            string stats = string.Empty;
            bool inputError = false;

            for (; ; )
            {
                Console.Write("직업 선택 (1:전사, 2:마법사, 3:궁수, 4:도적): ");

                jobChoice = int.Parse(Console.ReadLine());

                switch (jobChoice)
                {
                    case 1:
                        job = "전사";
                        trait = "높은 체력과 방어력";
                        stats = "HP +50, 공격력 +10";

                        break;

                    case 2:
                        job = "🔮 마법사";
                        trait = "강력한 마법 공격";
                        stats = "마나 +100, 마법력 +20";

                        break;

                    case 3:
                        job = "궁수";
                        trait = "원거리 공격 특화";
                        stats = "민첩 +15, 크리티컬 +10%";

                        break;

                    case 4:
                        job = "도적";
                        trait = "빠른 속도와 회피";
                        stats = "민첩 +20, 회피율 +15%";

                        break;

                    default:
                        inputError = true;

                        Console.WriteLine("잘못된 선택입니다. 1~4 중에서 선택해주세요.");

                        break;
                }

                if (!inputError)
                {
                    Console.WriteLine("\n=== 캐릭터 생성 ===");
                    Console.WriteLine($"{job} - {trait}");
                    Console.WriteLine($"시작 스탯: {stats}");

                    break;
                }

                inputError = false;
            }
        }
    }
}
