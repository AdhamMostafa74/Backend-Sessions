using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace OOP___5;

public class BookingHelper
{

    private static int Counter = 0;

    public static double CalcGroupDiscount(int numberOfTickets, double pricePerTicket) {

        if (numberOfTickets > 5) {

            return (pricePerTicket * numberOfTickets) * 0.9;

        }

        return pricePerTicket * numberOfTickets;


    }


    public static string GenerateBookingReference() {

        Counter++;

        return $"BK-{Counter}";
    
    }

    public static void PrintAll(IPrintable[] items)
    {
        foreach (IPrintable item in items)
        {
            Console.WriteLine(item.PrintTicket());
            Console.WriteLine("------------------");
        }
    }

}
