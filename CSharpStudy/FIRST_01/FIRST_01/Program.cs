using System;
using static System.Console;

namespace first_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //표현식과 문장
            Console.WriteLine("Hello World!");
            Console.WriteLine(273); //273
            Console.WriteLine(10 + 20 + 30 * 2); //90

            WriteLine("Hello World!");
            WriteLine(273); //273
            WriteLine(10 + 20 + 30 * 2); //90
            Console.WriteLine();

            Write("Hello World!");
            Write(273); //273
            Write(10 + 20 + 30 * 2); //90
            Console.WriteLine();


            //기본용어 : 키워드, 식별자, 주석, 출력

            //정수와 연산자
            Console.WriteLine(1 + 2); //3
            Console.WriteLine(1 - 2); //-1
            Console.WriteLine(1 * 2); //2
            Console.WriteLine(1 / 2); //0
            Console.WriteLine(1 % 2); //1
            Console.WriteLine();

            //연산자와 부호
            Console.WriteLine(4 % 3); // 1
            Console.WriteLine(-4 % 3); // -1
            Console.WriteLine(4 % -3); // 1
            Console.WriteLine(-4 % -3); // -1
            Console.WriteLine("\n");

            //실수
            Console.WriteLine(52.273);
            Console.WriteLine(0); //정수
            Console.WriteLine(0.0); //실수
            Console.WriteLine(1.0 + 2.0); //3
            Console.WriteLine(1.0 - 2.0); //-1
            Console.WriteLine(1.0 * 2.0); //2
            Console.WriteLine(1.0 / 2.0); //0.5
            Console.WriteLine(5.0 % 2.2); //0.5999 -> 이해하기 힘들므로 사용하지 않는 것을 추천
            Console.WriteLine("\n");

            //문자 : 글자 하나를 나타내는 자료형
            Console.WriteLine('A');
            Console.WriteLine('가');
            Console.WriteLine('나');
            Console.WriteLine("\n");

            //문자열 : 문자의 집합
            Console.WriteLine("안녕하세요");

            //이스케이프 문자
            Console.WriteLine("컴퓨터\t소프트웨어\t공학과");

            //문자열 연결 연산자(+)
            Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");
            Console.WriteLine("\n");

            //문자 선택
            Console.WriteLine("안녕하세요."[0]); //안
            Console.WriteLine("안녕하세요."[1]); //녕
            Console.WriteLine("안녕하세요."[5]); //.
                                            //Console.WriteLine("안녕하세요."[6]); //오류 : 예외, 런타임 오류

            //불 : 참과 거짓을 표현할 때 사용(비교연산자, 논리연산자)
            Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
            Console.WriteLine(3 < DateTime.Now.Hour && DateTime.Now.Hour < 8);
            Console.WriteLine("\n");




        }
    }
}
