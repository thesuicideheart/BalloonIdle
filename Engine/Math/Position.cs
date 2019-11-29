using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.Math
{
    public class Position
    {
        public int X;
        public int Y;

        public Position()
        {
            X = 0;
            Y = 0;
        }

        public Position(int val)
        {
            X = val;
            Y = val;
        }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void AddX(int x) { X += x; }
        public void AddY(int y) { Y += y; }

        public static Position operator + (Position pThis, Position other)
        {
            pThis.X += other.X;
            pThis.Y += other.Y;
            return pThis;
        }

        public static Position operator - (Position pThis, Position other)
        {
            pThis.X -= other.Y;
            pThis.Y -= other.Y;
            return pThis;
        }
    }
}
