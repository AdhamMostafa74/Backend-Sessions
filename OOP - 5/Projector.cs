using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___5;

public class Projector
{
    public bool IsOn { get; private set; }

    public void TurnOn()
    {
        IsOn = true;
        Console.WriteLine("Projector started.");
    }

    public void TurnOff()
    {
        IsOn = false;
        Console.WriteLine("Projector stopped.");
    }
}