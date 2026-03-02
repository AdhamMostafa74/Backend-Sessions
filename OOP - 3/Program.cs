namespace OOP___3;

internal class Program
{
    static void Main(string[] args)
    {


        #region

        /*
         * 
         * QUESTION 1:

         A) Composition class since the department cannot exist without the uni.

         B) Association class as the Driver uses the car but the car can exist independently

         C) Inheritance since the dog IS AN animal and inherits all its behaviors and fields

         D) Aggregation class because the Players still exist without the team 

         E) Association as the logger is only used by the method 
         but it still exists even if the method isnt called or available 


         */

        #endregion


        #region

        /*
         * 
         * QUESTION 2:
         
         A) A child can access the protected members of the parent class 
         even if its from a different assembly 
         but it can't be accessed after instantiation from outside


         B) 1. Private protected are accessible only inside the containign class and derived classes
            in the same project 
            
            2. Protected internal are accessible everywhere in the same project and also 
            other derived classes from different projects 
         

         C) 1. When applied to a class it will prevent this
            class from being inherited by other classes
         
            2. When applied to a method it will prevent this method
            from being overridden by derived classes

         D) Yes because sealed only prevents inheritance but doesnt prevent instantiation 

         */

        #endregion




        #region

        Cinema cinema = new Cinema
        {
            CinemaName = "IMAX Alexandria"
        };

        cinema.OpenCinema();


        StandardTicket standardTicket = new (
            movieName: "Inception",
            type: TicketType.Standard,
            seat: new Seat('A', 5),
            price: 120
        )
        {
            SeatNumber = "A-5"
        };

        VIPTicket vipTicket = new (
            movieName: "Avengers",
            price: 200
        )
        {
            LoungeAccess = true
        };

        IMAXTicket imaxTicket = new (
            movieName: "Dune",
            price: 180
        )
        {
            Is3D = false
        };

        cinema.AddTicket(standardTicket);
        cinema.AddTicket(vipTicket);
        cinema.AddTicket(imaxTicket);

        cinema.PrintAllTickets();

        Console.WriteLine("\n========= Statistics =========");
        Console.WriteLine($"Total Tickets Created: {Ticket.GetTotalTicket()}");

        string bookingRef1 = BookingHelper.GenerateBookingReference();
        string bookingRef2 = BookingHelper.GenerateBookingReference();

        Console.WriteLine($"\nBooking Ref 1: {bookingRef1}");
        Console.WriteLine($"Booking Ref 2: {bookingRef2}");

        int numberOfTickets = 5;
        double pricePerTicket = 100;

        double discountedTotal =
            BookingHelper.CalcGroupDiscount(numberOfTickets, pricePerTicket);

        Console.WriteLine(
            $"\nGroup Discount (5 x 100 EGP): {discountedTotal} EGP (10% off)"
        );

        cinema.CloseCinema();

        #endregion
    }
}
