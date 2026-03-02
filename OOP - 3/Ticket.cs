using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___3;

public class Ticket
{
    //properties and fields
    #region

    public string MovieName
    {
        get { return field; }

        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                field = value;
        }
    }
    public double Price
    {
        get { return field; }

        set { if (value != 0) field = value; }
    }
    public int TicketId { get; }

    private static int ticketCounter = 0;
    public double PriceAfterTax
    {
        get =>  Price * 1.14;
    }

    public  TicketType Type { get; set; }

    public Seat Seat { get; set; } = null!;



    private double DiscountedPrice;

    #endregion



    //constructors
    #region

    public Ticket(string movieName, TicketType type, Seat seat, double price)
    {
        MovieName = movieName;
        Type = type;
        Seat = seat;
        Price = price;
        ticketCounter++;
        TicketId = ticketCounter;

    }

    public Ticket(string movieName): this(
    movieName,
    TicketType.Standard,
    new Seat('A', 1),
    50
  )
    { }

    public Ticket(string movieName, double price) {
        MovieName = movieName;
        Price = price;
        ticketCounter++;
        TicketId = ticketCounter;
    }
    #endregion





    // methods
    #region


    public double ApplyDiscount(double discountAmount)
    {
        if (discountAmount > 0 && discountAmount < Price)
        {
            DiscountedPrice = Price - discountAmount;
        }
        else
        {
            DiscountedPrice = Price;
        }
        return DiscountedPrice;
    }

    public static double GetTotalTicket() {
        return ticketCounter;
    }


    public override string ToString()
    {
        return
            $"Ticket #{TicketId} | {MovieName} | " +
            $"Price: {Price} EGP | After Tax: {PriceAfterTax:F2} EGP";
    }
    #endregion


}
