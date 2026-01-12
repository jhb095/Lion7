using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// 사용자 입력을 문자열로 받기
            //Console.Write("이름을 입력하세요: ");
            //string userName = Console.ReadLine();   // 사용자로부터 입력 받기

            //Console.WriteLine($"안녕하세요, {userName}님!");


            // 문자열을 정수로 변환
            //Console.Write("나이를 입력하세요: ");
            //string input = Console.ReadLine();  // 사용자로부터 입력 받기
            //int age = int.Parse(input);  // 문자열을 정수로 변환

            //Console.WriteLine($"내년에는 {age + 1}살이 되겠군요!");

            //// 이진수를 정수로 변환
            //Console.Write("2진수를 입력하세요: ");
            //string binaryInput = Console.ReadLine();
            //int decimalValue = Convert.ToInt32(binaryInput, 2); // 2진수 -> 10진수 변환

            //string binaryOutput = Convert.ToString(decimalValue, 2); // 10진수 -> 2진수 변환

            //Console.WriteLine($"입력한 이진수: {binaryInput}");
            //Console.WriteLine($"10진수로 변환: {decimalValue}");
            //Console.WriteLine($"다시 2진수로 변환: {binaryOutput}");


            //Console.WriteLine("=== 캐릭터 생성 ===");
            //Console.Write("캐릭터 이름을 입력하세요: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"환영합니다, {name}님!");

            //Console.Write("시작 레벨을 입력하세요: ");
            //string input = Console.ReadLine();
            //int level = int.Parse(input);
            //Console.WriteLine($"{name}님의 시작 레벨은 {level}입니다.");


            //// var를 사용하여 변수 선언
            //var name = "Alice";     // 문자열로 추론
            //var age = 25;           // 정수로 추론
            //var isStudent = true;   // 논리값으로 추론

            //Console.WriteLine($"이름: {name}, 나이: {age}, 학생 여부: {isStudent}");


            // default 키워드를 사용한 기본값 설정
            //int defaultInt = default;       // 기본값: 0
            //string defaultString = default; // 기본값: null
            //bool defaultBool = default;     // 기본값: false

            //Console.WriteLine($"정수 기본값: {defaultInt}");
            //Console.WriteLine($"문자열 기본값: {defaultString}");
            //Console.WriteLine($"논리값 기본값: {defaultBool}");


            // 1. 암시적 변환 (작은 타입 -> 큰 타입)
            int smallNumber = 100;
            long largeNumber = smallNumber; // int -> long (암시적 변환)
            double preciseNumber = smallNumber; // int -> double (암시적 변환)

            Console.WriteLine("=== 암시적 변환 ===");
            Console.WriteLine($"int: {smallNumber.GetType()}");
            Console.WriteLine($"long: {largeNumber.GetType()}");
            Console.WriteLine($"double: {preciseNumber.GetType()}");

            // 2. 명시적 변환 (큰 타입 -> 작은 타입)
            double pi = 3.14159;
            int intPi = (int)pi; // 소수점 버림, double -> int (명시적 변환)
            
            Console.WriteLine("\n=== 명시적 변환 ===");
            Console.WriteLine($"double: {pi}");
            Console.WriteLine($"int: {intPi}");

            // 3. 문자열을 숫자로 변환
            string scoreText = "95";
            int score = int.Parse(scoreText); // 문자열 -> int (명시적 변환)

            string priceText = "19.99";
            double price = double.Parse(priceText); // 문자열 -> double (명시적 변환)

            Console.WriteLine("\n=== 문자열 변환 ===");
            Console.WriteLine($"점수(문자열): {scoreText} -> 숫자: {score}");
            Console.WriteLine($"가격(문자열): {priceText} -> 숫자: {price}");

            // 4. 숫자를 문자열로 변환
            int playerLevel = 50;
            string levelText = playerLevel.ToString(); // int -> 문자열

            Console.WriteLine("\n=== 숫자를 문자열로 ===");
            Console.WriteLine($"레벨(숫자): {playerLevel} -> 문자열: {levelText}");
        }
    }
}
