using System;

namespace Interface_2
{

    class Program
    {
        class TestClass : IBasic // (2)인터페이스 상속
        {
            // (3)인터페이스 구현 : 클래스에서 이후에 구현해줌
            public int TestProperty 
            {   get => throw new NotImplementedException(); 
                set => throw new NotImplementedException(); 
            }

            public int TestInstanceMethod()
            {
                throw new NotImplementedException();
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
