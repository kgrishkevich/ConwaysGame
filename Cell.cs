using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConwaysGame
{
    class Cell
    {
        public Cell(UInt64 x, UInt64 y)
        {
            X = x;
            Y = y;
            NeighborsCount = 0;
            IsAlive = false;
            Key = X.ToString() + "|" + Y.ToString();
        }

        public bool IsAlive { get; set; }

        public UInt64 X { get; set; }

        public UInt64 Y { get; set; }

        public string Key { get; private set; }

        public int NeighborsCount { get; set; }

    }
}
