using OOP___5;
using System;
using System.Text;

public class Cinema
{
    // Props and fields
    #region

    public string CinemaName { get; set; } = null!;
    private readonly Ticket[] tickets = new Ticket[20];
    private readonly Projector projector = new();

    #endregion


    // constructos
    #region

    public Cinema()
    {

    }


    #endregion


    // indexers and methods
    #region

    public Ticket? this[int index]
    {

        get
        {

            if (index >= tickets.Length || index < 0)
            {
                return null;
            }
            return tickets[index];

        }

        set
        {
            if (index >= tickets.Length || index < 0)
            {
                return;
            }
            tickets[index] = value!;
        }
    }

    public bool AddTicket(Ticket ticket)
    {

        if (ticket == null) { return false; }

        for (int i = 0; i < tickets.Length; i++)
        {

            if (tickets[i] == null)
            {
                tickets[i] = ticket;
                return true;
            }
        }

        return false;
    }

    //public string PrintAllTickets() {
    //    StringBuilder sb = new();
    //for (int i = 0; i<tickets.Length; i++)
    //    {
    //        if (tickets[i] != null)
    //        {
    //           sb.Append(tickets[i].PrintTicket()+ "\n");
    //        }
           
    //    }
    //    return sb.ToString();
    //}

    public void OpenCinema()
    {
        Console.WriteLine("========= Cinema Opened =========");

        projector.TurnOn();
    }

    public void CloseCinema()
    {
        Console.WriteLine("========= Cinema Closed =========");
        projector.TurnOff();
    }

    public static string ProcessTicket(Ticket ticket) {

       return ticket.PrintTicket();
    
    }

    public void PrintAllTickets()
    {
        foreach (Ticket t in tickets)
        {
            if (t != null)
            {
                Console.WriteLine(t.PrintTicket());
                Console.WriteLine("------------------");
            }
        }
    }

    #endregion


}
