using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___4;

internal class VIPTicket(string movieName, decimal price) : Ticket(movieName, price)
{
    public bool LoungeAccess{ get; set; }

    public override string PrintTicket()=>
        $"Ticket #{TicketId} | {MovieName} |" +
        $" Price: {Price:0.00} " +
        $"After Tax: {PriceAfterTax:0.00}" +
        $" + Lounge Access{LoungeAccess:0.00}" +
        $" | Service Fee: 50 EGP";



}
