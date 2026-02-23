using System;
using System.Collections.Generic;
using System.Text;

namespace Session_6__OOP2
{
    internal struct Test_Struct
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Test_Struct() { }

        public Test_Struct(int x, int y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"x: {X}, y: {Y}";
        }
    }
}
