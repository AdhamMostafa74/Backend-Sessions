using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___5;

internal class IMAXTicket(string movieName, decimal price) : Ticket(movieName,price: price)
{
    private bool _is3D;

    public bool Is3D
    {
        get => _is3D;
        set
        {
            _is3D = value;

            if (value)
                Price += 30;
        }
    }


    public override string PrintTicket()
    {
        if(Is3D)
        return $"Ticket #{TicketId} | {MovieName} |" +
                $" Price: {Price:0.00} | " +
                $"After Tax: {PriceAfterTax:0.00} | + IMAX 3D: Yes";
        else
            return $"Ticket #{TicketId} | {MovieName} |" +
               $" Price: {Price:0.00} | " +
               $"After Tax: {PriceAfterTax:0.00} |+ IMAX 3D: No";
    }

    public override object Clone()
    {
        IMAXTicket copy = new(MovieName, Price)
        {
            Is3D = Is3D
        };
        return copy;
    }
}
