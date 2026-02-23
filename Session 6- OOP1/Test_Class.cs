using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Session_6__OOP2
{
    internal class Test_Class
    {
        private int _X { get; set; }
        public int Y { get; set; }

        public Test_Class() { }

        public Test_Class(int x, int y)
        {
            _X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"x: {_X}, y: {Y}";
        }

    }
}
