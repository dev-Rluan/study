using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boxes
{
    class BoxE
    {
        private int width;
        public int Width
        {
            get; set;
        }

        private int height;
        public int Height
        {
            get; set;
        }

        public BoxE(int width, int height) //생성자
        {
            Width = width;
            Height = height;
        }
        public int Area() { return this.Width * this.Height; }

    }
}
