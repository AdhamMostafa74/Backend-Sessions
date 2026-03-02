using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___4;

internal class StandardTicket(string movieName, decimal price) : Ticket(movieName, price)
{
    public string SeatNumber { get; set; } = null!;


    public override string PrintTicket() => $"Ticket #{TicketId} | {MovieName} |" +
                $" Price: {Price:0.00} " +
                $"After Tax: {PriceAfterTax:0.00} + Seat {SeatNumber}";
}
