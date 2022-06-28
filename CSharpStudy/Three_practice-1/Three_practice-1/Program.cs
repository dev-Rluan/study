using System;

namespace Three_practice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 273;
            int b = 52;

            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine();

            Console.WriteLine("int : " + sizeof(int));
            Console.WriteLine("long: " + sizeof(long));
            Console.WriteLine("float: " + sizeof(float));
            Console.WriteLine("double: " + sizeof(double));
            Console.WriteLine("char: " + sizeof(char));
            Console.WriteLine();

            //복합 대입 연산자 : 자료형에 적용하는 기본 연산자와 =(대입) 연산자를 함께 사용
            int output = 0;
            output += 52;
            output += 273;
            output += 103;
            Console.WriteLine(output);
            Console.WriteLine(); // 428
            Console.WriteLine();

            //증감 연산자
            int number1 = 10;
            number1++;
            Console.WriteLine(number1); //11
            number1--;
            Console.WriteLine(number1); //10
            Console.WriteLine();

            int number2 = 20;
            Console.WriteLine(number2); //20
            Console.WriteLine(number2++); //20
            Console.WriteLine(number2--); //21
            Console.WriteLine(number2); //20
            Console.WriteLine();

            int number3 = 30;
            Console.WriteLine(number3); //30
            Console.WriteLine(++number3); //31
            Console.WriteLine(--number3); //30
            Console.WriteLine(number3); //30
            Console.WriteLine();

            int number4 = 40;
            Console.WriteLine(number4++); //40
            Console.WriteLine(++number4); //42
            Console.WriteLine(number4--); //42
            Console.WriteLine(--number4); //40
            Console.WriteLine();

            int number5 = 50;
            Console.WriteLine(number5); //50
            number5++;
            number5++;
            Console.WriteLine(number5); //52
            number5--;
            number5--;
            Console.WriteLine(number5); //50
            Console.WriteLine();
            Console.WriteLine();

            //자료형 검사
            //GetType() 메서드를 활용
            int _int = 273;
            long _long = 522731033265;
            float _float = 52.273F;
            double _double = 52.273;
            char _char = '글';
            string _string = "문자열";

            // GetType() 메서드를 활용해서 자료형 출력
            Console.WriteLine(_int.GetType());
            Console.WriteLine(_long.GetType());
            Console.WriteLine(_float.GetType());
            Console.WriteLine(_double.GetType());
            Console.WriteLine(_char.GetType());
            Console.WriteLine(_string.GetType());
            Console.WriteLine();
            Console.WriteLine();

            // 작접적인 GetType() 메서드를 활용
            Console.WriteLine((273).GetType());
            Console.WriteLine((522731033265L).GetType());
            Console.WriteLine((52.273F).GetType());
            Console.WriteLine((52.273).GetType());
            Console.WriteLine(('자').GetType());
            Console.WriteLine(("문자열").GetType());

            //var 키워드 : 자료형을 자동으로 지정
            var global = 52;
            var number6 = 100;
            Console.WriteLine();

            // var 키워드를 사용한 다양한 자료형 선언
            var numberA = 100;  //int 자료형
            var numberB = 100L;  // long 자료형
            var numberC = 100.13;  // double 자료형
            var numberD = 100.15F;  // float 자료형

            //입력
            /*string input1 = Console.ReadLine();
            Console.WriteLine("input1: " + input1);

            string input = Console.ReadLine();
            Console.WriteLine("input: " + input);
            Console.WriteLine();*/

            long longNumber = 2147483647L + 2147483647L;
            int intNumber = longNumber;
            Console.WriteLine(intNumber);














        }
    }
}
