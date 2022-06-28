using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxC
    {
        private int Width; // 변수
        private int Height;

        public BoxC(int width, int height) // 생성자 정의
        {
            if (width > 0 && height > 0)
            {
                this.Width = width;
                this.Height = height;
            }

            else { Console.WriteLine("너비와 높이는 자연수로 초기화해 주세요!"); }
        }

        public int Area() { return this.Width * this.Height; } // 인스턴스 메서드 정의

        public int GetWidth() { return Width; } // 겟터(Getter)
        public int GetHeight() { return Height; }

        public void SetWidth(int width) // 셋터(Setter)
        {
            if (width > 0) { this.Width = width; }
            else { Console.WriteLine("너비는 자연수를 입력해 주세요"); }
        }

        public void SetHeight(int height)
        {
            if (height > 0) { this.Height = height; }
            else { Console.WriteLine("높이는 자연수를 입력해 주세요"); }
        }
    }
}
