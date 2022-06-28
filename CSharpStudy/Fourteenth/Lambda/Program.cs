using System;

namespace Lambda
{
    delegate int Calculate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //Calculate calc = (int a, int b) => a + b;
            Calculate calc = (a, b) => a + b;
            Console.WriteLine($"3 + 4 : {calc(3, 4)}");
        }
    }
}
