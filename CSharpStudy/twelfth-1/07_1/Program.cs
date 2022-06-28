using System;

namespace _07_1
{
    class Parent
    {
        public Parent()
        {
            Console.WriteLine("부모 생성자");
        }
    }

    class Child : Parent
    {
        public Child() : base()
        {
            Console.WriteLine("자식 생성자");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Child child = new Child(); //자식 인스턴스 생성
        }
    }
}
