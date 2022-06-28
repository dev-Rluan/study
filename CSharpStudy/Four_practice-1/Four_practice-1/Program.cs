using System;

namespace Four_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //자료형 변환 : 한 자료형을 다른 자료형으로 바꾸는 것
            /*long longNumber = 2147483647L + 2147483647L;
            int intNumber = longNumber;
            Console.WriteLine(intNumber);

            //강제 자료형 변환
            var a = (int)10.0;
            var b = (float)10;
            var c = (double)10;

            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);

            //강제 자료형 변환 -> 데이터 손실
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            long longNumber1 = 52273;
            int intNumber1 = (int)longNumber1;
            Console.WriteLine(intNumber1);
            Console.WriteLine();

            //문자열을 숫자로 변환
            Console.WriteLine(int.Parse("52"));
            Console.WriteLine(long.Parse("273"));
            Console.WriteLine(float.Parse("52.273"));
            Console.WriteLine(double.Parse("103.32"));

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(long.Parse("273").GetType());
            Console.WriteLine(float.Parse("52.273").GetType());
            Console.WriteLine(double.Parse("103.32").GetType());

            //숫자로 변환할 수 없는 문자열을 변환하는 경우 -> 에외가 발생
            Console.WriteLine(int.Parse("52.275"));
            Console.WriteLine(int.Parse("abc"));

            //다른 자료형을 문자열로 변환
            //기본 자료형을 문자열로 변환
            Console.WriteLine((52).ToString());
            Console.WriteLine((52.273).ToString());
            Console.WriteLine(('a').ToString());
            Console.WriteLine((true).ToString());
            Console.WriteLine((false).ToString());
            Console.WriteLine((52).ToString().GetType());
            Console.WriteLine((52.273).ToString().GetType());

            //소수점 제거
            double number = 52.273103;
            Console.WriteLine(number.ToString("0.0"));
            Console.WriteLine(number.ToString("0.00"));
            Console.WriteLine(number.ToString("0.000"));
            Console.WriteLine(number.ToString("0.0000"));

            //숫자와 문자열 덧셈 : 숫자가 자동으로 문자열로 변환
            Console.WriteLine(52 + 273);
            Console.WriteLine("52" + 273);
            Console.WriteLine(52 + "273");
            Console.WriteLine("52" + "273");

            Console.WriteLine("inch 단위 입력 : ");
            double inch = double.Parse(Console.ReadLine());
            Console.WriteLine(inch + "inch는 " + (inch * 2.54) + "cm입니다.");

            Console.WriteLine("kg 단위 입력 : ");
            double kg = double.Parse(Console.ReadLine());
            Console.WriteLine(kg + "kg은 " + (kg * 2.20462262) + "pound입니다.");

            Console.WriteLine("원의 반지름 입력 : ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine("원의 둘레 : " + (2 * 3.14 * radius));
            Console.WriteLine("원의 넓이 : " + (3.14 * radius * radius));

            //조건문
            //짝수 홀수 구분
            //if (불_표현식)
            Console.WriteLine("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }

            if (input % 2 == 1)
            {
                Console.WriteLine("홀수입니다!");
            }

            //if else 조건문
            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }

            else
            {
                Console.WriteLine("홀수입니다!");
            }

            //switch 조건문
            switch (input % 2)
            {
                case 0:
                    Console.WriteLine("짝수입니다!");
                    break;

                case 1:
                    Console.WriteLine("홀수입니다!");
                    break;
            }*/

            //오전과 오후 구분
            //현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);







        }
    }
}
