using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___2;

    internal class Class1
    {
    public Class1(int x, int y)
    {
        X = x;
        Y = y;
    }

    public int X { get; }
    public int Y { get; }

    public int Sum() {
        return X + Y;
    }

   
}

