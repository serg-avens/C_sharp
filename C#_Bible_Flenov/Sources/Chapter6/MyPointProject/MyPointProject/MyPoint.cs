﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPointProject
{
    class MyPoint
    {
        public MyPoint(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        int x;
        public int X { 
            get { return x; }
            set { x = value; }
        }
        int y;
        public int Y
        {
            get { return y; }
            set { x = value; }
        }

        public override string ToString()
        {
            return x.ToString() + ":" + y.ToString();
        }
    }
}
