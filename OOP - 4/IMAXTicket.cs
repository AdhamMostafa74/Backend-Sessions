using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___4;

internal class IMAXTicket(string movieName, decimal price) : Ticket(movieName,price: price)
{
    public bool Is3D { get;
        set
        {
            if (value == true)
                Price += 30;
        }
    }


    public override string PrintTicket()
    {
        if(Is3D)
        return $"Ticket #{TicketId} | {MovieName} |" +
                $" Price: {Price:0.00} " +
                $"After Tax: {PriceAfterTax:0.00} + IMAX 3D: Yes";
        else
            return $"Ticket #{TicketId} | {MovieName} |" +
               $" Price: {Price:0.00} " +
               $"After Tax: {PriceAfterTax:0.00} + IMAX 3D: No";
    }
}
