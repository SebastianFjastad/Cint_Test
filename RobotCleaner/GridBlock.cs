using System;
using System.Collections.Generic;
using System.Text;

namespace RobotCleaner
{
    public class GridBlock
    {
        public GridBlock(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int X { get; set; }
        public int Y { get; set; }

        public GridBlock Clone()
        {
            return new GridBlock(this.X, this.Y);
        }
    }
}
