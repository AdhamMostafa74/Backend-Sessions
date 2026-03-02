using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___3;

internal class StandardTicket : Ticket
{

    public string SeatNumber { get; set; } = null!;

    public StandardTicket(string movieName, TicketType type, Seat seat, double price) : base(movieName, type, seat, price)
    {
    }

    public override string ToString()
    {
        return $"Ticket #{TicketId} | {MovieName} |" +
                $" Price: {Price:0.00} " +
                $"After Tax: {PriceAfterTax:0.00} + Seat{SeatNumber}";
    }
}
