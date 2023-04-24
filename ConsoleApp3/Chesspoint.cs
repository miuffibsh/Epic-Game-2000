using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class ChessPoint
    {
        public static bool operator == (ChessPoint p1, ChessPoint p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return true;
            }
            return false;
        }

        public static bool operator != (ChessPoint p1, ChessPoint p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
            {
                return false;
            }
            return true;
        }

        public int x { get; set; }
        public int y { get; set; }
        public ChessPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public bool right(int limit)
        {
            x++;
            if (x == limit)
            {
                x--;
                return false;
            }
            return true;
        }
        public bool left(int limit)
        {
            x--;
            if (x == limit)
            {
                x++;
                return false;
            }
            return true;
        }
        public bool up(int limit)
        {
            y--;
            if (y == limit)
            {
                y++;
                return false;
            }
            return true;
        }
        public bool down(int limit)
        {
            y++;
            if (y == limit)
            {
                y--;
                return false;
            }
            return true;
        }
    }
}
