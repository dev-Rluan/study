using System;

namespace Ninth_practice_3
{
    class Program
    {
        class Parent
        {
            public int Qu() { return 10; }

        }
        class Child : Parent
        {
            public new int Qu() { return 20; }
        }
        
        static void Main(string[] args)
        {
            /*Book book1 = new Book();

            book1.Title = "죽고 싶지만 떡볶이는 먹고 싶어";
            book1.Content = "어두운 면을 드러내는 건 내가 자유로워지는 하나의 방법이다.";
            book1.Writer = "백세희";
            book1.publisher = "도서출판 흔";
            book1.published_Date = 20210503;

            Console.WriteLine("제  목 : " + book1.Title);
            Console.WriteLine("내  용 : " + book1.Content);
            Console.WriteLine("저  자 : " + book1.Writer);
            Console.WriteLine("출판사 : " + book1.publisher);
            Console.WriteLine("출판일 : " + book1.published_Date);
            Console.WriteLine();

            Book book2 = new Book();

            book2.Title = "완벽하지 않은 것들에 대한 사랑";
            book2.Content = "온전한 나를 위한 혜민 스님의 따뜻한 응원";
            book2.Writer = "혜민";
            book2.publisher = "수오서재";
            book2.published_Date = 20150203;

            Console.WriteLine("제  목 : " + book2.Title);
            Console.WriteLine("내  용 : " + book2.Content);
            Console.WriteLine("저  자 : " + book2.Writer);
            Console.WriteLine("출판사 : " + book2.publisher);
            Console.WriteLine("출판일 : " + book2.published_Date);*/

            /*Product product = new Product();

            product.name = "감자";
            product.price = 2000;
            Console.WriteLine(product.name + " : " + product.price + "원");*/

            /*Product productA = new Product() { name = "감자", price = 2000 };
            Product productB = new Product() { name = "고구마", price = 3000 };

            Console.WriteLine(productA.name + " : " + productA.price + "원");
            Console.WriteLine(productB.name + " : " + productB.price + "원");*/

            String[] a = new String[10];
            int.Parse("two");
            Console.WriteLine("안녕하세요"[100]);
            Random random = new Random();



        }
    }
}
