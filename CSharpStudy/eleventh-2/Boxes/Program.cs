using System;

namespace Boxes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BoxA boxA = new BoxA(-10, -10);
            Console.WriteLine(boxA.Area());

            BoxB boxB = new BoxB(10, 10);
            Console.WriteLine(boxB.Area());

            BoxC boxC = new BoxC(10, 10);
            Console.WriteLine(boxC.Area());

            BoxD boxD = new BoxD(10, 10);
            Console.WriteLine(boxD.Area());*/

            BoxE boxE = new BoxE(-10, 10);
            Console.WriteLine(boxE.Area());
            Console.WriteLine(boxE.Width);

        }
    }
}
