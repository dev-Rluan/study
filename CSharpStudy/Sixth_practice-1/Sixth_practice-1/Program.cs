using System;
using System.Threading;

namespace Sixth_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int score_1 = 80;
            int score_2 = 74;
            int score_3 = 81;
            int score_4 = 90;
            int score_5 = 34;

            Console.WriteLine(score_1);
            Console.WriteLine(score_2);
            Console.WriteLine(score_3);
            Console.WriteLine(score_4);
            Console.WriteLine(score_5);

            int average = (score_1 + score_2 + score_3 + score_4 + score_5) / 5;
            Console.WriteLine("average : " + average); // 기본 출력
            Console.WriteLine("average : {0}", average); // string format
            Console.WriteLine($"average : {average}"); // 문자열 보간($)을 이용한 문자열 출력

            int[] scores = new int[5];
            scores[0] = 80;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 90;
            scores[4] = 34;

            foreach (int score in scores)
                Console.WriteLine(score);

            //배열을 초기화 하는 방법 네 가지
            int[] scores = new int[5];
            scores[0] = 86;
            scores[1] = 74;
            scores[2] = 81;
            scores[3] = 95;
            scores[4] = 67;

            //int[] scores = new int[5] { 86, 74, 81, 95, 67 };
            //int[] scores = new int[] { 86, 74, 81, 95, 67 };
            //int[] scores = { 86, 74, 81, 95, 67 };

            // Length 속성
            int[] intArray = { 52, 273, 32, 65, 103 };
            Console.WriteLine(intArray.Length);

            // 무한 반복 : 종료하려면 [Ctrl] + [c]
            while (true)
            {
                Console.WriteLine("무한 반복");
            }

            for (; ; )
            {
                Console.WriteLine("무한 반복");
            }

            int i = 0;
            while (true)
            {
                Console.WriteLine(i++);
            }

            int i = 0;
            for (; ; )
            {
                Console.WriteLine(i++);
            }

            //while 반복문
            int i = 0;
            int[] intArray = { 52, 273, 32, 65, 103 };

            Console.WriteLine("\"while 반복문\"");
            Console.WriteLine();

            while (i < intArray.Length)
            {
                //Console.WriteLine(i "번째 출력 : " intArray[i]);                
                //Console.WriteLine(i, "번째 출력 : " , intArray[i]);
                Console.WriteLine(i + "번째 출력 : " + intArray[i]);
                i++;
            }
            Console.WriteLine();

            //do while 반복문
            string input;
            do
            {
                Console.Write("입력(exit를 입력하면 종료) : ");
                input = Console.ReadLine();
            } while (input != "exit");
            Console.WriteLine();

            //for 반복문으로 덧셈하기
            int output = 0;
            for (int i = 0; i <= 100; i++)
            {
                output += i;
            }
            Console.WriteLine(output);
            Console.WriteLine();

            //for 반복문으로 곱셈하기
            var output = 1; //uint, var, long
            for (var i = 1; i <= 20; i++)
            {
                output *= i;
            }
            Console.WriteLine(output);
            Console.WriteLine();

            //한글 전부 출력하기
            for (int i = '가'; i <= '힣'; i++)
            {
                //Console.Write(i);
                Console.Write((char)i);
            }
            Console.WriteLine();

            //중첩 반복문 : 별 피라미드(1)
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write("*");

                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();*/

            //Thread.Sleep() 메서드
            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1500);
            Console.WriteLine("두 번째 출력");
            Thread.Sleep(1500);
            Console.WriteLine("두 번째 출력");

            //이동하는 달팽이
            int x = 1;
            while (x < 50)
            {
                // 화면을 지우고 커서를 이동합니다.
                Console.Clear();
                Console.SetCursorPosition(x, 5);

                // 출력합니다.
                if (x % 3 == 0)
                    Console.WriteLine(" __@");
                else if (x % 3 == 1)
                    Console.WriteLine("_^@");
                else
                    Console.WriteLine("^_@");

                // 100밀리초 정지하고 x를 증가합니다.
                Thread.Sleep(100);
                x++;
            }

            //switch 조건문과 무한 반복문
            bool state = true;
            while (state)
            {
                ConsoleKeyInfo info = Console.ReadKey();
                switch (info.Key)
                {
                    case ConsoleKey.UpArrow:
                        Console.WriteLine("위로 이동");
                        break;
                    case ConsoleKey.RightArrow:
                        Console.WriteLine("오른쪽으로 이동");
                        break;
                    case ConsoleKey.DownArrow:
                        Console.WriteLine("아래로 이동");
                        break;
                    case ConsoleKey.LeftArrow:
                        Console.WriteLine("왼쪽으로 이동");
                        break;
                    case ConsoleKey.X:
                        state = false;
                        break;
                }
            }

        }
    }
}
