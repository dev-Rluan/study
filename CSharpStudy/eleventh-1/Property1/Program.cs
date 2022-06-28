using System;

namespace Property1
{

    class MyClass
    {
        //int 형식 myField를 private로 갖고 있는 클래스
        /*private int myField;
        public int GetMyField() { return myField; }
        public void SetMyField(int NewValue) { myField = NewValue; }
    }
        //get 접근자와 set 접근자를 사용하여 프로퍼티(속성) 선언
        private int myField;
        public int MyField
        {
            get
            {
                return myField;
            }
            set
            {
                myField = value; //value는 set 접근자의 암묵적 매개변수로 간주
            }
        }*/

        //자동구현 프로퍼티(속성)
        private int myField;
        public int MyField
        {
            get; set;
        }

        class Program
        {
            static void Main(string[] args)
            {
                /*MyClass obj = new MyClass();
                obj.SetMyField(3);
                Console.WriteLine(obj.GetMyField());*/

                MyClass obj = new MyClass();
                obj.MyField = 3;
                Console.WriteLine(obj.MyField);

                Console.Read();
            }
        }
    }
}
