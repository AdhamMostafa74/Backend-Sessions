using System;
using System.Collections.Generic;
using System.Text;

namespace OOP___2
{
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

        public TicketType Type { get; set; }

        public Seat Seat { get; set; } = null!;

        public double Price
        {
            get { return field; }

            set { if (value != 0) field = value; }
        }

        public double PriceAfterTax
        {
            get =>  Price * 1.14;
        }

        private double DiscountedPrice;

        private static int ticketCounter = 0;

        public int TicketId { get; }



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

        public Ticket(string movieName)
    : this(
        movieName,
        TicketType.Standard,
        new Seat('A', 1),
        50
      )
        {
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

        public static double GetTotalTicketSold() {
            return ticketCounter;
        }


        public override string ToString()
        {
            return
                    $"""
            ===== Ticket Info =====
            Movie          : {MovieName}
            Type           : {Type}
            Seat           : {Seat}
            Price          : {Price:0.00}
            Total (14% tax) : {PriceAfterTax:0.00}

            ===== After Discount =====
            Discount Before : {DiscountedPrice:0.00}
            Discount After  : 0.00
            Movie          : {MovieName}
            Type           : {Type}
            Seat           : {Seat}
            Price          : {DiscountedPrice:0.00}
            Total (14% tax) : {PriceAfterTax:0.00}
            """;
        }

        #endregion


    }
}
