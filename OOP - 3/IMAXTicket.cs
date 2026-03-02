using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___3;

internal class IMAXTicket(string movieName, double price) : Ticket(movieName, price)
{
    public bool Is3D { get;
        set
        {
            if (value == true)
                Price += 30;
        }
    }


    public override string ToString()
    {
        return $"Ticket #{TicketId} | {MovieName} |" +
                $" Price: {Price:0.00} " +
                $"After Tax: {PriceAfterTax:0.00} + IMAX 3D: {Is3D}";
    }
}
