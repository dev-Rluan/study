using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninth_practice_2
{
    class Cat
    {
        public string Name;
        public int Age;
        private int Happiness;

        public Cat(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public void GetBored()
        {
            Happiness = Happiness - 10;
            if (Happiness < 0)
                Happiness = 0;
        }
        public void Play()
        {
            Happiness = Happiness + 10;
            if (Happiness > 100)
                Happiness = 100;
        }
        public void Eat()
        {
            Happiness = Happiness + 20;
            if (Happiness > 100)
                Happiness = 100;
        }
        public string Express() //Happiness의 상태에 따라 고양이 자신을 표현
        {
            string message = "";

            if (Happiness >= 80)
                message = "I'm very happy~ 야옹";
            else if (Happiness >= 60)
                message = "I'm happy~ 야옹";
            else if (Happiness >= 40)
                message = "I'm so so~ 야옹";
            else if (Happiness >= 20)
                message = "I'm gloomy~ 야옹";
            else
                message = "I'm sad~ 야옹";

            return this.Name + " : " + message;
        }





    }
}
