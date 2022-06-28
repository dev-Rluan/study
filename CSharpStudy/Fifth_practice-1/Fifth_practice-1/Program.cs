using System;

namespace Fifth_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*//중첩 조건문 활용
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }

            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
            }
            Console.WriteLine();

            //if else if 조건문
           if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }

            else if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
            else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }

            //논리 연산자와 조건문
            double score = 2.0;

            if (4.0 < score && score < 4.5)
            {

            }

            //논리 연산자와 조건문
            Console.WriteLine("학점 입력 : ");
            double scoreA = double.Parse(Console.ReadLine());

            if (scoreA == 4.5)
                Console.WriteLine("신");
            //else if (4.2 <= scoreA && scoreA < 4.5)
            else if (4.2 <= scoreA)
                Console.WriteLine("교수님의 사랑");
            //lse if (3.5 <= scoreA && scoreA < 4.2)
            else if (3.5 <= scoreA)
                Console.WriteLine("현 체제의 수호자");
            //else if (2.8 <= scoreA && scoreA < 3.5)
            else if (2.8 <= scoreA)
                Console.WriteLine("일반인");
            else if (2.3 <= scoreA && scoreA < 2.8)
                Console.WriteLine("일탈을 꿈꾸는 소시민");
            else if (1.75 <= scoreA && scoreA < 2.3)
                Console.WriteLine("오락문화의 선구자");
            else if (1.0 <= scoreA && scoreA < 1.74)
                Console.WriteLine("불가촉천민");
            else if (0.5 <= scoreA && scoreA < 1.0)
                Console.WriteLine("자벌레");
            else if (0 < scoreA && scoreA < 0.5)
                Console.WriteLine("플랑크톤");
            else
                Console.WriteLine("시대를 앞서가는 혁명의 씨앗");

            //switch 조건문

            //break 키워드를 사용하지 않는 switch 조건문
            Console.Write("이번 달은 몇 월인가요: ");
            int input = int.Parse(Console.ReadLine());

            switch (input)
            {
                case 12:
                case 1:
                case 2:
                    Console.WriteLine("겨울입니다.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄입니다.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름입니다.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을입니다.");
                    break;
                default:
                    Console.WriteLine("대체 어떤 행성에 살고 계신가요?");
                    break;
            }

            //삼항 연산자
            Console.WriteLine("숫자 입력 : ");
            int number = int.Parse(Console.ReadLine());

            //int number = 52273;
            Console.WriteLine(number % 2 == 0 ? true : false);
            Console.WriteLine(number % 2 == 0 ? "짝수" : "홀수");

            // 키 입력

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
                default:
                    Console.WriteLine("다른 키를 눌렀습니다");
                    break;
            }

            //연습문제 07
            Console.Write("태어난 년도: ");
            int birth = int.Parse(Console.ReadLine());

            switch (birth % 12)
            {
                case 0: Console.WriteLine("원숭이 띠입니다."); break;
                case 1: Console.WriteLine("닭 띠입니다."); break;



                default:
                    break;
            }

            //연습문제 08
            Console.Write("현재가 몇 월인지 입력해주세요: ");
            int year = int.Parse(Console.ReadLine());

            if (3 <= year && year <= 5)
            {
                Console.WriteLine("봄입니다.");
            }

            else if (6 <= year && year <= 8)
            {
                Console.WriteLine("여름입니다.");





            }

            //반복문을 사용한 반복
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("출력");

            }

            //기본적인 배열 생성 방법
            int[] intArray = { 52, 273, 32, 65, 103 };
            long[] longArrat = { 52, 273, 32, 65, 103 };
            float[] floatArray = { 1.0F, 2.0F, 3.0F, 4.0f, 5.0F };
            double[] doubleArray = { 1.0, 2.0, 3.0, 4.0, 5.0 };
            char[] charArray = { '가', '나', '다', '라' };
            string[] stringArray = { "홍길동", "유산슬", "강호돌" };

            Console.WriteLine(intArray[0]);
            Console.WriteLine(intArray[1]);
            Console.WriteLine(intArray[2]);
            Console.WriteLine(intArray[3]);
            Console.WriteLine(intArray[4]);
            Console.WriteLine(doubleArray[4]);
            //Console.WriteLine(intArray[5]);
            Console.WriteLine(intArray.Length);*/

            //원하는 크기의 배열 생성 방법
            int[] intArray = new int[100]; //new : 메모리 할당 연산자
            Console.WriteLine(intArray[0]); //일반적인 숫자 자료형은 0으로 초기화
            Console.WriteLine(intArray[99]);

            char[] charArray = new char[100];
            Console.WriteLine(charArray[0]); //문자열 자료형은 빈문자열로 초기화
            Console.WriteLine(charArray[99]);







        }
    }
}
