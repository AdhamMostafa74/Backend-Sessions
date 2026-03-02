using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___4;

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
    public decimal Price
    {
        get { return field; }

        set { if (value != 0) field = value; }
    }
    public int TicketId { get; }

    private static int ticketCounter = 0;
    public decimal PriceAfterTax
    {
        get =>  Price * 1.14m;
    }

    public  TicketType Type { get; set; }

    public Seat Seat { get; set; } = null!;



    private decimal DiscountedPrice;

    #endregion



    //constructors
    #region

    public Ticket(string movieName, TicketType type, Seat seat, decimal price)
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

    public Ticket(string movieName, decimal price) {
        MovieName = movieName;
        Price = price;
        ticketCounter++;
        TicketId = ticketCounter;
    }
    #endregion



    // methods
    #region


    public decimal ApplyDiscount(decimal discountAmount)
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

    public static int GetTotalTicket() {
        return ticketCounter;
    }

    public virtual string PrintTicket()
    => $"Ticket #{TicketId} | {MovieName} | " +
        $"Price: {Price} EGP | After Tax:" +
        $" {PriceAfterTax:F2} EGP";

    public string SetPrice(decimal price) {
        Price = price;
        return $"Setting price directly {Price}"; 
            }
    public string SetPrice(decimal price, decimal multiplier)
    {
         
        return $"Setting price with multiplier: {Price} x {multiplier} = {price * multiplier}";
    }


    #endregion


}
