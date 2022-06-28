using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxB
    {
        private int Width; //변수
        private int Height;

        public BoxB(int width, int height) //생성자 정의
        {
            if (width > 0 && height > 0)
            {
                this.Width = width;
                this.Height = height;
            }
            else
            {
                Console.WriteLine("너비와 높이는 자연수로 초기화해 주세요!");
            }
        }

        public int Area()
        {
            return this.Width * this.Height;
        }

    }
}
