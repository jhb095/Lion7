using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Student
    {
        // 필드 선언
        private string name;
        private int score;
        private char grade;

        // Name 프로퍼티 (읽기 전용)
        public string Name { get; private set; }

        // Score 프로퍼티 (0~100 검증)
        public int Score
        {
            get { return score; }

            set
            {
                if(value < 0 || value > 100)
                {
                    Console.WriteLine("성적이 잘못됐습니다.");

                    return;
                }

                score = value;
            }
        }

        // Grade 프로퍼티 (자동 계산, 읽기 전용)
        public char Grade
        {
            get
            {
                if (score >= 90) return 'A';
                else if (score >= 80) return 'B';
                else if (score >= 70) return 'C';
                else if (score >= 60) return 'D';
                else return 'F';
            }

            private set { grade = value; }
        }

        // 생성자
        public Student(string studentName)
        {
            Name = studentName;
        }

        // 정보 출력
        public void ShowInfo()
        {
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
            Console.WriteLine($"이름: {Name}");
            Console.WriteLine($"점수: {Score}점");
            Console.WriteLine($"등급: {Grade}");
            Console.WriteLine($"━━━━━━━━━━━━━━━━");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("홍길동");

            student.Score = 95;
            student.ShowInfo();

            Console.WriteLine();

            student.Score = 75;
            student.ShowInfo();

            Console.WriteLine();

            // 잘못된 값 입력 시도
            student.Score = 150;  // 100으로 제한되어야 함
            student.Score = -10;  // 0으로 제한되어야 함
            student.ShowInfo();
        }
    }
}
