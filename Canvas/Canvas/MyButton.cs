using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Canvas
{
    class MyButton
    {
        protected Point toleft;
        protected Point bottomRight;
        internal int width;
        internal int height;

        internal MyButton(Point toleft, Point bottomRight)
        {
            this.toleft = toleft;
            this.bottomRight = bottomRight;
        }
        internal static int GetWidth(int width)
        {
            return width;
        }
        internal static int GetHeight(int height)
        {
            return height;
        }

    }
}
