using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class Point
    {
        int x;
        int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        internal int GetX(int x)
        {
            return x;
        }
        internal int GetY(int y)
        {
            return y;
        }
        internal void SetX(int x)
        {
            Console.WriteLine(x);
        }
        internal void SetY(int y)
        {
            Console.WriteLine(y);
        }

        public override string ToString()
        {
            return $"x = {x} y = {y}";
        }
    }
}
