using OOP___3;
using System;

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
            tickets[index] = value;
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

    public void PrintAllTickets() { 
    
    for (int i = 0; i<tickets.Length; i++)
        {
            if (tickets[i] != null)
            {
                Console.WriteLine(tickets[i]);
            }
            else
            {
                return;
            }
        }
    
    }

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
    #endregion


}
