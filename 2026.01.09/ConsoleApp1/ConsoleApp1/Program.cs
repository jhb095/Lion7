using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            //// 배열 -> 효율적

            //// 방법 1
            //int[] scores = new int[5];

            //// 방법 2: 초기값과 함께 선언
            //int[] numbers = new int[] { 10, 20, 30, 40, 50 };

            //// 방법 3: 간단한 초기화
            //int[] values = { 1, 2, 3, 4, 5 };

            //// 방법 4
            //scores[0] = 1;
            //scores[1] = 2;
            //scores[2] = 3;
            //scores[3] = 4;
            //scores[4] = 5;

            //for(int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine(scores[i]);
            //}


            //// 인벤토리 시스템 (최대 5개)
            //string[] inventory = new string[5];
            //string s;

            //// 아이템 추가
            //while (true)
            //{
            //    Console.Write("추가할 아이템 입력: ");

            //    s = Console.ReadLine();

            //    if (string.IsNullOrEmpty(s)) break;

            //    for (int i = 0; i < inventory.Length; i++) {
            //        if (string.IsNullOrWhiteSpace(inventory[i]))
            //        {
            //            inventory[i] = s;

            //            break;
            //        }
            //    }
            //}

            //// 인벤토리 출력
            //Console.WriteLine("=== 인벤토리 ===");

            //for (int i = 0; i < inventory.Length; i++)
            //{
            //    Console.WriteLine($"[{i + 1}] {inventory[i]}");
            //}


            //// === 캐릭터 스탯 ===
            //// HP: 100
            //// MP: 50
            //// 공격력: 80
            //// 방어력: 60
            //// 민첩: 45
            //string[] characterStatsName = new string[] { "HP", "MP", "공격력", "방어력", "민첩" };
            //int[] characterStats = new int[] { 100, 50, 80, 60, 45 };

            //Console.WriteLine("=== 캐릭터 스탯 ===");

            //for(int i = 0; i < characterStatsName.Length; i++)
            //{
            //    Console.WriteLine($"{characterStatsName[i]}: {characterStats[i]}");
            //}


            //string[] monstersName = { "고블린", "오크", "슬라임", "드래곤", "좀비" };
            //int[] curDailyQuest = { 5, 3, 8, 2, 7 };
            //int[] goalDailyQuest = { 5, 5, 5, 5, 5 };

            //Console.WriteLine("=== 일일 퀘스트 진행도 ===");

            //for(int i = 0; i < monstersName.Length; i++)
            //{
            //    Console.WriteLine($"{monstersName[i]}: {curDailyQuest[i]} / {goalDailyQuest[i]} {(curDailyQuest[i] >= goalDailyQuest[i] ? "✅ 완료" : "⏳ 진행중")}");
            //}


            //int[] scores = { 85, 92, 78, 95, 88 };

            //// 배열 길이
            //Console.WriteLine($"총 점수 개수: {scores.Length}");

            //// 배열 순회
            //Console.WriteLine("개별 점수");

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    Console.WriteLine($"플레이어 {i + 1}: {scores[i]}점");
            //}

            //// 합계 계산
            //int sum = 0;

            //for (int i = 0; i < scores.Length; i++)
            //{
            //    sum += scores[i];
            //}

            //Console.WriteLine($"총점: {sum}점");
            //Console.WriteLine($"평균: {sum / (float)scores.Length}점");


            //int maxScore = -1, minScore = 101;

            //// 최고점 및 최저점 찾기
            //for(int i = 0; i < scores.Length; i++)
            //{
            //    if (scores[i] > maxScore)
            //    {
            //        maxScore = scores[i];
            //    }

            //    if (scores[i] < minScore)
            //    {
            //        minScore = scores[i];
            //    }
            //}

            //Console.WriteLine($"최고점: {maxScore}점");
            //Console.WriteLine($"최저점: {minScore}점");


            //// Array 클래스 메서드 활용
            //Console.WriteLine("=== Array 메서드 ===");

            //// 정렬
            //int[] sortedScores = (int[])scores.Clone(); // 복사본 생성

            //Array.Sort(sortedScores);

            //Console.Write("정렬 후: ");

            //foreach(int score in sortedScores)
            //{
            //    Console.Write($"{score} ");
            //}

            //Console.WriteLine();

            //// 역순 정렬
            //Array.Reverse(sortedScores);

            //Console.Write("역순: ");

            //foreach(int score in sortedScores)
            //{
            //    Console.Write($"{score} ");
            //}

            //Console.WriteLine();


            //// 검색
            //int searchScore = 92;
            //int index = Array.IndexOf(scores, searchScore);

            //Console.WriteLine($"{searchScore}점의 위치: 인덱스 {index}");
            //Console.WriteLine($"찾은 값: {scores[index]}");

            //int[,] arr = new int[3, 4];

            //// 전체 요소 개수
            //int totalElements = arr.Length;

            //// 특정 차원의 길이
            //int rows = arr.GetLength(0);
            //int cols = arr.GetLength(1);

            //int dimensions = arr.Rank;


            //=== 좌석 배치도 ===

            // [A1][A2][A3]
            // [B1][B2][B3]
            // [C1][C2][C3]

            //string[,] arr = new string[,] {
            //    {"A1", "A2", "A3" },
            //    {"B1", "B2", "B3" },
            //    {"C1", "C2", "C3" }
            //};

            //for (int i = 0; i < arr.GetLength(0); i++)
            //{
            //    for (int j = 0; j < arr.GetLength(1); j++)
            //    {
            //        Console.Write($"[{arr[i, j]}]");
            //    }

            //    Console.WriteLine();
            //}


            //// 첫번째 좌석: A1
            //// 중앙 좌석: B2
            //// 마지막 좌석: C3
            //Console.WriteLine($"첫 번째 좌석: {arr[0, 0]}");
            //Console.WriteLine($"중앙 좌석: {arr[1, 1]}");
            //Console.WriteLine($"마지막 좌석: {arr[2, 2]}");


            //// 2D 게임맵
            //int[,] map = new int[5, 5]
            //{
            //    { 0, 0, 1, 0, 0 },
            //    { 0, 2, 1, 0, 3 },
            //    { 0, 0, 1, 0, 0 },
            //    { 1, 1, 1, 0, 0 },
            //    { 0, 0, 0, 0, 9 }
            //};

            //Console.WriteLine("==던전맵==");
            //Console.WriteLine("0: 통로 1: 벽 2: 몬스터 3: 보물 9: 출구\n");

            //for(int y = 0; y < map.GetLength(0); y++)
            //{
            //    for(int x = 0; x < map.GetLength(1); x++)
            //    {
            //        switch(map[y, x])
            //        {
            //            case 0:
            //                Console.Write("⬜ ");

            //                break;

            //            case 1:
            //                Console.Write("⬛ ");

            //                break;

            //            case 2:
            //                Console.Write("👹 ");

            //                break;

            //            case 3:
            //                Console.Write("💎 ");

            //                break;

            //            case 9:
            //                Console.Write("🚪 ");

            //                break;
            //        }
            //    }

            //    Console.WriteLine();
            //}


            //string[] names = { "김철수", "이영희", "박민수" };
            //int[,] scores = new int[3, 4]
            //{
            //    { 85, 90, 88, 92 },
            //    { 78, 85, 90, 87 },
            //    { 92, 88, 95, 90 }
            //};

            //Console.WriteLine("=== 성적표 ===\n");
            //Console.WriteLine("이름\t국어\t영어\t수학\t과학\t평균");
            //Console.WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");

            //for(int i = 0; i < scores.GetLength(0); i++)
            //{
            //    int avg = 0;

            //    Console.Write($"{names[i]}\t");

            //    for(int j = 0; j < scores.GetLength(1); j++)
            //    {
            //        avg += scores[i, j];

            //        Console.Write($"{scores[i, j]}\t");
            //    }

            //    Console.WriteLine($"{(avg / (float)scores.GetLength(1)):N1}");
            //}

            //Console.WriteLine("\n=== 과목별 평균 ===");
            //string[] subjectNames = { "국어", "영어", "수학", "과학" };

            //for(int i = 0; i < subjectNames.Length; i++)
            //{
            //    int avg = 0;

            //    for(int j = 0; j < scores.GetLength(0); j++)
            //    {
            //        avg += scores[j, i];
            //    }

            //    Console.WriteLine($"{subjectNames[i]}: {(avg / (float)scores.GetLength(0)):N1}점");
            //}


            //// 가변 배열
            //string[][] raid = new string[3][];

            //raid[0] = new string[] { "전사", "힐러", "마법사", "궁수" };
            //raid[1] = new string[] { "도적", "전사", "힐러" };
            //raid[2] = new string[] { "마법사", "궁수", "힐러", "전사", "탱커" };

            //Console.WriteLine("=== 레이드 파티 구성 ===");

            //for(int i = 0; i < raid.Length; i++)
            //{
            //    Console.Write($"파티 {i + 1} ({raid[i].Length}명): ");

            //    for(int j = 0; j < raid[i].Length; j++)
            //    {
            //        Console.Write($"{raid[i][j]} ");
            //    }

            //    Console.WriteLine();
            //}


            //| 특징 | 배열 | List<T> |
            //| ------| ------| ---------|
            //| 크기 | 고정 | 자동 조절 |
            //| 추가 / 삭제 | 불가 | 가능 |
            //| 성능 | 약간 빠름 | 약간 느림 |
            //| 편의성 | 기본 | 다양한 메서드 제공 |

            //// 선언 방법
            //List<int> numbers = new List<int>();
            //List<string> names = new List<string>();
            //List<float> prices = new List<float>();

            //// 초기값과 함께 선언
            //List<int> scores = new List<int> { 85, 90, 78, 95 };
            //List<string> items = new List<string> { "검", "방패", "포션" };

            //// C# 3.0 이후 간단한 초기화
            //var players = new List<string> { "철수", "영희", "민수" };
            //List<string> items = new List<string>();

            //// Add: 끝에 추가
            //items.Add("회복 포션");
            //items.Add("마나 포션");

            //// List 생성
            //List<string> inventory = new List<string>();

            //Console.WriteLine("=== 도적 인벤토리 시스템 ===");

            //// 아이템 추가 (Add)
            //inventory.Add("회복 포션");
            //inventory.Add("마나 포션");
            //inventory.Add("강철 검");

            //Console.WriteLine("아이템 3개 추가");

            //// 현재 인벤토리
            //Console.WriteLine($"인벤토리 ({inventory.Count}개): ");

            //for(int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            //Console.WriteLine();

            //inventory[0] = "초록 포션";

            //for(int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            //Console.WriteLine();

            //// 특정 위치에 추가 (Insert)
            //inventory.Insert(1, "전설 검");

            //for(int i = 0;i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            //Console.WriteLine();

            //// 아이템 제거 (Remove)
            //inventory.Remove("초록 포션");

            //for(int i = 0; i <inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}

            //Console.WriteLine();

            //// 인덱스로 제거 (RemoveAt)
            //inventory.RemoveAt(0);

            //for(int i = 0; i < inventory.Count; i++)
            //{
            //    Console.WriteLine($"[{i}] {inventory[i]}");
            //}


            //Dictionary<string, int> stats = new Dictionary<string, int>();

            //// 데이터 추가
            //stats.Add("HP", 150);
            //stats.Add("MP", 80);
            //stats.Add("공격력", 75);
            //stats.Add("방어력", 50);
            //stats.Add("민첩", 60);

            //Console.WriteLine("=== 캐릭터 스탯 ===");

            //foreach(KeyValuePair<string, int> stat in stats)
            //{
            //    Console.WriteLine($"{stat.Key}: {stat.Value}");
            //}

            //// 키 존재 확인
            //string searchStat = "방어력";

            //if (stats.ContainsKey(searchStat))
            //{
            //    Console.WriteLine(stats[searchStat]);
            //} else
            //{
            //    Console.WriteLine("해당 스탯이 없습니다.");
            //}


            //=== 상점 아이템 ===
            //회복 포션: 50골드
            //마나 포션: 40골드
            //강철 검: 500골드
            //가죽 갑옷: 300골드
            //마법 반지: 1000골드

            //✅ '강철 검' 구매 성공!
            //남은 골드: 100

            Dictionary<string, int> shopItems = new Dictionary<string, int>();
            int playerGold = 600;

            shopItems.Add("회복 포션", 50);
            shopItems.Add("마나 포션", 40);
            shopItems.Add("강철 검", 500);
            shopItems.Add("가죽 갑옷", 300);
            shopItems.Add("마법 반지", 1000);

            Console.WriteLine("=== 상점 아이템 ===");

            foreach (KeyValuePair<string, int> item in shopItems)
            {
                Console.WriteLine($"{item.Key}: {item.Value}골드");
            }

            while (true)
            {
                string input;

                Console.Write("구매할 아이템: ");

                input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input)) break;

                if (shopItems.ContainsKey(input))
                {
                    if (playerGold >= shopItems[input])
                    {
                        playerGold -= shopItems[input];

                        Console.WriteLine($"✅ '{input}' 구매 성공!\n남은 골드: {playerGold}");
                    }
                    else
                    {
                        Console.WriteLine($"{shopItems[input] - playerGold}골드가 부족합니다.");
                    }
                }
                else
                {
                    Console.WriteLine("판매하지 않는 아이템 입니다.");
                }
            }
        }
    }
}
