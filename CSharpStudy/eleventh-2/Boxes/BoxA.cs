using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxA
    {
        public int Width;
        public int Height;

        public BoxA(int width, int height) //생성자 정의
        {
            this.Width = width;
            this.Height = height;
        }
        public int Area() //메서드 정의
        {
            return this.Width * this.Height;
        }

    }
}
