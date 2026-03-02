using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___3;

internal class VIPTicket(string movieName, double price) : Ticket(movieName, price)
{
    public bool LoungeAccess{ get; set; }

    public override string ToString()
    {
        return $"Ticket #{TicketId} | {MovieName} |" +
                $" Price: {Price:0.00} " +
                $"After Tax: {PriceAfterTax:0.00} + Lounge Access{LoungeAccess:0.00} | Service Fee: 50 EGP";
    }
}
