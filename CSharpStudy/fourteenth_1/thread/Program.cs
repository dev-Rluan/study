using System;
using System.Threading;

namespace thread
{
    class Program
    {
        static void ThreadBody()  // 1. 스레드 몸체에 해당하는 메서드를 작성
        {
            for (int i = 0; i <= 15; i++)
            {
                Console.WriteLine(DateTime.Now.Second + " : " + i);
                Thread.Sleep(1000);
            }
        }

        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(ThreadBody);
            // 2. 작성된 메서드를  ThreadStart 델리게이트에 연결
            Thread t = new Thread(ts);
            // 3. 생성된 델리게이트를 이용하여 스레드 객체를 생성

            Console.WriteLine("*** Start of Main");
            t.Start();  // 4. Start() 메서드를 호출하여 스레드의 실행을 시작
            Console.WriteLine("*** End of Main");
        }
    }
}
