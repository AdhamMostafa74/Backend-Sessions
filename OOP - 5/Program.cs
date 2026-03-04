namespace OOP___5;

internal class Program
{
    static void Main(string[] args)
    {

        #region

        /*
         * 
         * QUESTION 1
         
         A) Interface is a contract that defines some behavior in which classes can implement
        it is used to acheive abstraction and multiple inheritance that can provide more flexibility 
        and also acheive polymorphism

        interfaces are better than classes as it doenst have tight coupling and can be changed easily

        benefits of interface: 
        1. applies polymorphism without inheritance 
        2. remove tight coupling between classes
        3. provides a way to achieve multiple inheritance
        
         */

        #endregion

        #region

        /*
         * 
         * QUESTION 2
         
            A) There is a problem where both interfaces have the same method name and signature
            currently the class is having a conflict so it prints the "Hello / Ahlan"

            B) We can use explicit interface implementation and separate both methods 
            so for the arabic speaker we can implement it : IArabicSpeaker.Greet() 
            while for english : IEnglishSpeaker.Greet() 
            and then change the implentation as we desire 

            C) No we cant call the method directly from translator class
               we need to cast the object to the interface first then call the method 

               IArabicSpeaker as = translator;
               IEnglishSpeaker es = translator;
               as.Greet();
               es.Greet();
            

         
         */

        #endregion

        #region

        /*
         * 
         * QUESTION 3 
         
            Shallow copy helps in copying the the objects but it only copies the reference for 
            reference type , so if we change the value of a refernce type data in either 
            the copy or the original it will affect both 

            on the other hand , the deep copy creates a new object and copies all the values accordingly
            creating new reference for changes in refernec type data 


            Shallow copy can cause problems when there are reference type data as I mentioned before
            it only copies the reference so any change will affect both objects 
         
         */

        #endregion

        #region

        /*
         * 
         * QUESTION 4
         
         for the first console write , it will print Dev - Testing
         for the second one it will print            QA - Testing 

         this actually happend because , as the string is reference type , its immutable 
         so when the reference changed , it changed the object from the department but created
         a new one for the title 
         
         */

        #endregion

        #region

        // a. Create Cinema and open it
        Cinema cinema = new();
        cinema.OpenCinema();

        // b. Create tickets with hardcoded data
        StandardTicket t1 = new("Movie 1", 150) { SeatNumber = "b-4" };
        VIPTicket t2 = new("Movie 2", 200) { LoungeAccess = true,  };
        IMAXTicket t3 = new("Movie 2", 130) { Is3D = true };

        // Book them
        t1.Book();
        t2.Book();
        t3.Book();

        // Add to cinema
        cinema.AddTicket(t1);
        cinema.AddTicket(t2);
        cinema.AddTicket(t3);

        // c. Print all tickets
        Console.WriteLine("\n--- All Tickets ---");
        cinema.PrintAllTickets();


        // d. Clone VIP ticket
        Console.WriteLine("\n--- Clone Test ---");

        VIPTicket clone = (VIPTicket)t2.Clone();
        clone.MovieName = "Interstellar";

        Console.WriteLine("Original : " + t2.PrintTicket());
        Console.WriteLine("Clone    : " + clone.PrintTicket());


        // e. Cancel one ticket and print it again
        Console.WriteLine("\n--- After Cancellation ---");

        t1.Cancel();

        Console.WriteLine(t1.PrintTicket());


        // f. Use BookingHelper utility method
        Console.WriteLine("\n--- BookingHelper.PrintAll ---");

        IPrintable[] printables =
        [
            t1,
            t2,
            t3
        ];

        BookingHelper.PrintAll(printables);


        // g. Close cinema
        cinema.CloseCinema();

        #endregion
    }
}
