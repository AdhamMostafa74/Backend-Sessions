using System;
using System.Collections.Generic;
using System.Text;

namespace Session_6__OOP2
{
    internal class Ticket
    {

        public string MovieName { get; set; }
        public TicketType Type { get; set; }
        public Seat Seat { get; set; } = null!;
        private double Price { get; set; }

        private double TaxedPrice;

        private double DiscountedPrice;
       

        public Ticket(string movieName, TicketType type, Seat seat, double price)
        {
            MovieName = movieName;
            Type = type;
            Seat = seat;
            Price = price;
        }

        public Ticket(string movieName)
    : this(
        movieName,
        TicketType.Standard,
        new Seat('A' , 1),
        50
      )
        {
        }


        public double CalcTotal(double taxPrice) {
            TaxedPrice = Price * taxPrice;
            return TaxedPrice;
        }

        public double ApplyDiscount(double discountAmount) {
            if (discountAmount > 0 && discountAmount < Price)
            {
                DiscountedPrice = Price - discountAmount;
            }
            else {
                DiscountedPrice = Price;
            }
            return DiscountedPrice;
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
            Total (14% tax) : {(Price + TaxedPrice):0.00}

            ===== After Discount =====
            Discount Before : {DiscountedPrice:0.00}
            Discount After  : 0.00
            Movie          : {MovieName}
            Type           : {Type}
            Seat           : {Seat}
            Price          : {DiscountedPrice:0.00}
            Total (14% tax) : {TaxedPrice:0.00}
            """;
        }

    }
}
