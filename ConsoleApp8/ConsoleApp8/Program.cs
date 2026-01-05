using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 실수 데이터 형식: 소수점을 포함한 숫자를 표현
            //float singlePrecision = 3.14f;                              // 단정밀도 실수 (4바이트)
            //double doublePrecision = 3.1415926535;                      // 배정밀도 실수 (8바이트)
            //decimal highPrecision = 3.1415926535897932384626433833m;    // 고정밀도 실수 (16바이트)

            //Console.WriteLine(singlePrecision);
            //Console.WriteLine(doublePrecision);
            //Console.WriteLine(highPrecision);


            //// 접미사 사용: 숫자의 데이터 형식을 명시
            //int integerValue = 100;         // 기본 정수형 (int)
            //long longValue = 100L;          // 정수형 (long)
            //float floatValue = 3.14f;       // 실수형 (float)
            //double doubleValue = 3.14;      // 기본 실수형 (double)
            //decimal decimalValue = 3.14m;   // 고정밀도 실수형 (decimal)

            //Console.WriteLine(integerValue);
            //Console.WriteLine(longValue);
            //Console.WriteLine(floatValue);
            //Console.WriteLine(doubleValue);
            //Console.WriteLine(decimalValue);


            //// char 형식: 단일 문자를 표현
            //char letter = 'A';  // 문자 'A' 저장
            //char symbol = '#';  // 특수 기호 저장
            //char number = '9';  // 숫자 형태의 문자 저장

            //Console.WriteLine(letter);
            //Console.WriteLine(symbol);
            //Console.WriteLine(number);


            //float moveSpeed = 5.5f;
            //double attackSpeed = 1.25;
            //decimal itemPrice = 12.99m;

            //Console.WriteLine("==== 캐릭터 능력치 ====");
            //Console.WriteLine($"이동속도 {moveSpeed}");
            //Console.WriteLine($"공격속도 {attackSpeed}");
            //Console.WriteLine($"아이템 가격 {itemPrice}");


            //// string 형식: 여러 문자를 저장
            //string greeting = "Hello, World!";  // 문자열 저장
            //string name = "Alice";

            //Console.WriteLine(greeting);
            //Console.WriteLine(name);


            //char grade = 'A';
            //char symbol = '★';
            //char number = '9';

            //string playerName = "홍길동";
            //string welcomeMessage = "게임에 오신 것을 환영합니다!";
            //string emptyString = "";

            //Console.WriteLine("=== RPG 게임 ===");
            //Console.WriteLine($"플레이어: {playerName}");
            //Console.WriteLine($"등급: {grade}등급 {symbol}");
            //Console.WriteLine(welcomeMessage);


            //// bool 형식: 참(True) 또는 거짓(False)
            //bool isRunning = true;      // 프로그램 실행 상태
            //bool isFinished = false;    // 프로그램 종료 상태

            //Console.WriteLine(isRunning);
            //Console.WriteLine(isFinished);


            //bool isRunning = true;
            //bool isPause = false;
            //bool hasKey = false;
            //bool isOpenedDoor = false;
            //bool isPlayerAlive = true;
            //int health = 80;
            //bool isHealthy = true;
            //bool isHazard = false;


            //Console.WriteLine("=== 게임 상태 ===");
            //Console.WriteLine($"게임 실행 중: {isRunning}");
            //Console.WriteLine($"일시정지: {isPause}");
            //Console.WriteLine($"열쇠 소지: {hasKey}");
            //Console.WriteLine($"문 열림: {isOpenedDoor}");
            //Console.WriteLine($"플레이어 생존: {isPlayerAlive}");

            //Console.WriteLine("\n=== 캐릭터 상태 ===");
            //Console.WriteLine($"체력: {health}");
            //Console.WriteLine($"건강 상태: {isHealthy}");
            //Console.WriteLine($"위험 상태: {isHazard}");


            //// 닷넷 형식: 기본 형식의 닷넷 표현
            //System.Int32 number = 123;      // int의 닷넷 형식
            //System.String text = "Hello";   // string의 닷넷 형식
            //System.Boolean flag = true;     // bool의 닷넷 형식

            //Console.WriteLine(number);
            //Console.WriteLine(text);
            //Console.WriteLine(flag);


            int number = 123;
            string numberAsString = number.ToString();  // 정수를 문자열로 변환
            
            bool flag = true;
            string boolAsString = flag.ToString();      // 논리값을 문자열로 변환

            Console.WriteLine(numberAsString);
            Console.WriteLine(boolAsString);
        }
    }
}
