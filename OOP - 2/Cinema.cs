using OOP___2;
using System;

public class Cinema
{
    private Ticket[] tickets = new Ticket[20];


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

	public Ticket? GetMovieByName(string movieName) {

		if (string.IsNullOrWhiteSpace(movieName))
		{

			return null;
		}

		for (int i = 0; i < tickets.Length; i++)
		{

			if (tickets[i].MovieName.Equals(movieName, StringComparison.OrdinalIgnoreCase))
			{
				return tickets[i];
			}
		}

		return null;
	}


	public bool AddTicket(Ticket ticket) {

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

	public Cinema()
	{
		  
	}
}
