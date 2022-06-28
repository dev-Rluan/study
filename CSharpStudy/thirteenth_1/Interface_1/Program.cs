using System;
using System.Collections.Generic;

namespace Interface_1
{
    class Program
    {
        //(1) 기본적인 클래스와 자료 생성
        class Product : IComparable // (2) IComparable 인터페이스 상속하기
        {
            public string Name { get; set; }
            public int Price { get; set; }

            // (3) IComparable 인터페이스의 메서드 생성
            public int CompareTo(object obj)
            {
                //return this.Price.CompareTo((obj as Product).Price);
                return this.Name.CompareTo((obj as Product).Name);
                //throw new NotImplementedException();
            }

            public override string ToString()
            {
                return Name + " : " + Price + "원";
            }
        }

        static void Main(string[] args)
        {
            List<Product> list = new List<Product>()
            {
                new Product() { Name = "고구마", Price = 1500 },
                new Product() { Name = "사과", Price = 2400 },
                new Product() { Name = "바나나", Price = 1000 },
                new Product() { Name = "배", Price = 3000 }
            };
            list.Sort();

            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }
    }
}
