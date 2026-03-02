namespace OOP___4;

internal class Program
{
    static void Main(string[] args)
    {

        #region

        /*
         * 
         * QUESTION 1:
         
            A) Static binding is when the method call is resolved in the 
               compile time before the code even run , it happens when using method overloading 
               or when there is static methods or at method hiding in subclasses 

               Dynamic binding on the other hand happens when the method call is resolved at runtime 
               it happenes when overriding methods in subclasses using the virtual keyword in base class 
               and override in subclass and in interface calls 

            B) Method overloading is when there is multiple methods with the same name and same class 
               but with different signatures like parameters or types 
               
               While method overriding is when there is a method in the base class that has a specific type
               of implementation that we need to alter in the subclass so we use the same name in both classes
               and use keyword virtual in the base class and override in the subclass 


            C) For method overriding we use keyword virtual in the base class and override in the subclass
               Virtual means that the method can be overridden as it will be in the VTable of the class
               so when the subclass override the method it will be in the VTable of the subclass as well 
               with its own implementation 
         
         */

        #endregion


        #region

        var cinema = new Cinema();

        cinema.OpenCinema();


        StandardTicket standardTicket = new(
             movieName: "Inception",
             price: 120
         )
        {
            SeatNumber = "A-5"
        };


        VIPTicket vipTicket = new(
           movieName: "Avengers",
           price: 200
       )
        {
            LoungeAccess = true
        };

        IMAXTicket imaxTicket = new(
            movieName: "Dune",
            price: 180
        )
        {
            Is3D = false
        };
        Console.WriteLine("\n=============SetPrice Test===============");
        Console.WriteLine(standardTicket.SetPrice(60m));
        Console.WriteLine(standardTicket.SetPrice(price: 60m, multiplier: 1.15m));

        Console.WriteLine("\n=============All Tickets===============");

        cinema.AddTicket(standardTicket);
        cinema.AddTicket(vipTicket);
        cinema.AddTicket(imaxTicket);

        Console.WriteLine(cinema.PrintAllTickets());
        Console.WriteLine("\n=============Process Single Ticket===============\n");

        Console.WriteLine("\n" +Cinema.ProcessTicket(imaxTicket) + "\n");
        cinema.CloseCinema();


        #endregion
    }
}
