using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___5;

internal class StandardTicket(string movieName, decimal price) : Ticket(movieName, price)
{
    public string SeatNumber { get; set; } = null!;


    public override string PrintTicket() => $"Ticket #{TicketId} | {MovieName} " +
           $"| Standard | Seat: {SeatNumber} | " +
           $"Price: {Price:0.##} | After Tax: {PriceAfterTax:0.##} | " +
           $"Booked: {(IsBooked ? "Yes" : "No")}";

  
    public override object Clone()
    {
        StandardTicket copy = new(MovieName, Price)
        {
            SeatNumber = SeatNumber
        };
        return copy;
    }
}
