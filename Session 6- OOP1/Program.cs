// See https://aka.ms/new-console-template for more information

using Session_6__OOP2;
using System;
using System.Net.Sockets;

class Program {

    public static void Main(string[] args)
    {

        #region

        ///* 

        // * First Im gonna create 2 objects from Test class 

        //Classes are reference type , so when we assign a class object to another , it 
        //copies the reference of the other object in the heap , if there are
        //any changes happneing to either of them , it will reflect on the other one as well

        // */

        //Test_Class a = new Test_Class(40, 30);
        //Console.WriteLine($"{a} before assigning b");

        //Test_Class b = a;
        //b.X = 123;
        //b.Y = 456;

        //Console.WriteLine($"{a} after assigning b");
        //Console.WriteLine(b);

        ///*

        //Here in struct , its actually a value type , so when we assign a struct object to another 
        //it take all the values into a complete clone and both of them are independent

        // */
        //Test_Struct c = new Test_Struct(40, 30);
        //Console.WriteLine($"{c} before assigning b");
        //Test_Struct d = c;
        //d.X = 400;
        //d.Y = 456;
        //Console.WriteLine($"{c} after assigning b");

        //Console.WriteLine(d);


        #endregion

        #region
        ///*

        //public access means that the thing im using it with public is available everywhere even outside the project 
        //while private is going to be accessible just inside the class im using and not accessible outside the scope of it 

        // */

        //Test_Class public_class = new Test_Class(30, 40);

        //// Here since X is private , it can only be accesible inside the class 
        //// Y on the other hand is public so its accessible anywhere
        //Console.WriteLine(public_class.X);
        //Console.WriteLine(public_class.Y);

        #endregion



        #region

        // in order for us to create a class library , we right click on the solution
        // select Add, Select Add new project  ,then search for class library


        // a class library is a dll file that can contain multiple class without a 
        // run file so it can be reusable across multiple projects and also helps in organization

        #endregion


        #region



        Console.Write("Enter Movie Name: ");
        string movie = Console.ReadLine()!;

        Console.Write("Enter Ticket Type (1 = Standard , 2 = VIP , 3 = IMAX ): ");
        TicketType type = (TicketType)int.Parse(Console.ReadLine()!);

        Console.Write("Enter Seat Row (A, B, C...): ");
        char row = char.Parse(Console.ReadLine()!);

        Console.Write("Enter Seat Number: ");
        int number = int.Parse(Console.ReadLine()!);

        Console.Write("Enter Price: ");
        double price = double.Parse(Console.ReadLine()!);

        Console.Write("Enter Discount Amount: ");
        double discount = double.Parse(Console.ReadLine()!);

        Ticket ticket = new Ticket(movie, type, new Seat(row, number), price);

        ticket.CalcTotal(0.14);
        ticket.ApplyDiscount(30);
        Console.WriteLine(ticket);


        #endregion
    }


}