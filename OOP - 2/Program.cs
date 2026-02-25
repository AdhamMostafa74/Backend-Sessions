namespace OOP___2;

public class Program
{
    public static void Main(string[] args)
    {



        //QUESITON 5

        #region

        Cinema cinema = new Cinema();

        Console.WriteLine("========== Ticket Booking ==========\n");

        // A: Enter data for 3 tickets
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine($"Enter data for Ticket {i + 1}:");

            Console.Write("Movie Name: ");
            string movieName = Console.ReadLine()!;

            Console.Write("Ticket Type (0=Standard, 1=VIP, 2=IMAX): ");
            TicketType type = (TicketType)int.Parse(Console.ReadLine()!);

            Console.Write("Seat Row (A-Z): ");
            char row = char.Parse(Console.ReadLine()!);

            Console.Write("Seat Number: ");
            int number = int.Parse(Console.ReadLine()!);

            Console.Write("Price: ");
            double price = double.Parse(Console.ReadLine()!);

            Seat seat = new Seat(row, number);
            Ticket ticket = new Ticket(movieName, type, seat, price);

            cinema.AddTicket(ticket);
            Console.WriteLine();
        }

        // B: Print all tickets using indexer
        Console.WriteLine("========== All Tickets ==========\n");

        for (int i = 0; i < 3; i++)
        {
            Ticket? ticket = cinema[i];
            if (ticket != null)
            {
                Console.WriteLine(
                    $"Ticket #{ticket.TicketId} | " +
                    $"{ticket.MovieName} | {ticket.Type} | " +
                    $"Seat: {ticket.Seat} | " +
                    $"Price: {ticket.Price} EGP | " +
                    $"After Tax: {ticket.PriceAfterTax:0.0} EGP"
                );
            }
        }

        // C: Search by movie name
        Console.WriteLine("\n========== Search by Movie ==========\n");

        Console.Write("Enter movie name to search: ");
        string search = Console.ReadLine()!;

        Ticket? found = cinema.GetMovieByName(search);

        if (found != null)
        {
            Console.WriteLine(
                $"Found: Ticket #{found.TicketId} | " +
                $"{found.MovieName} | {found.Type} | " +
                $"Seat: {found.Seat} | Price: {found.Price} EGP"
            );
        }
        else
        {
            Console.WriteLine("Movie not found.");
        }

        // D: Total tickets sold
        Console.WriteLine("\n========== Statistics ==========\n");
        Console.WriteLine($"Total Tickets Sold: {Ticket.GetTotalTicketSold()}");

        // E: Generate booking references
        Console.WriteLine($"\nBooking Reference 1: {BookingHelper.GenerateBookingReference()}");
        Console.WriteLine($"Booking Reference 2: {BookingHelper.GenerateBookingReference()}");

        // F: Group discount
        double discountedTotal = BookingHelper.CalcGroupDiscount(5, 80);

        Console.WriteLine(
            $"\nGroup Discount (5 tickets ): {discountedTotal} EGP (10% off applied)"
        );



        #endregion



    }
}


    
    

