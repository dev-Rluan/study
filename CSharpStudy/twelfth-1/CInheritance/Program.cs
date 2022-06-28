using System;
using System.Collections.Generic;

namespace CInheritance
{
    class Animal
    {
        public int Age { get; set; }
        public Animal() { this.Age = 0; }
        public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
        public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }

    }

    class Dog : Animal
    {
        public string Color { get; set; }
        public void Bark() { Console.WriteLine("왈왈왈 짓습니다."); }

    }

    class Cat : Animal
    {
        public void Meow() { Console.WriteLine("야아옹~ 웁니다."); }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>() 
            { 
                new Dog(), new Dog(), new Cat(), new Cat(),
                new Cat(), new Dog(), new Cat(),new Dog(),
            };

            foreach (var item in Animals)
            {
                item.Eat();
                item.Sleep();

                /*((Dog)item).Bark();
                ((Cat)item).Meow();

                var a = (int)10.5; //10
                var b = (float)10.5; //10.5*/

                //일반적인 자료형 변환
                if (item is Dog)
                {
                    ((Dog)item).Bark();
                }

                if (item is Cat)
                {
                    ((Cat)item).Meow();
                }

                // as 키워드를 사용한 자료형 변환
                // 코드 7-16: as 키워드를 사용한 자료형 변환
                if (item is Dog) { (item as Dog).Bark(); }
                if (item is Cat) { (item as Cat).Meow(); }

                //as 키워드를 사용하는 경우의 일반적인 형태
                var dog = item as Dog;
                if (dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }



            }

        }
    }
}
