using Session5c_;
using System;
using System.Collections.Generic;
using System.Text;





//QUESTION 1
/*

Console.WriteLine("Enter a day's number! (1-7)");

int dayNumber;

bool isParsed = int.TryParse(Console.ReadLine(), out dayNumber);

foreach (Day day in Enum.GetValues(typeof(Day)))
{
    if (dayNumber == (int)day)
    {
        Console.WriteLine($"Day:{day}");
        switch (day)
        {
            case Day.Sunday:
            case Day.Monday:
            case Day.Tuesday:
            case Day.Wednesday:
            case Day.Thursday:

                Console.WriteLine("It's a work day!");
                break;

            case Day.Saturday:
            case Day.Friday:

                Console.WriteLine("It's a weekend");
                break;

        }
    }

}
*/

//QUESTION 2
/*
Console.WriteLine("Enter the size of the array");
int arrayLength = int.Parse(Console.ReadLine());

int[] arrayStats = new int[arrayLength];

for (int i = 0; i < arrayLength; i++)
{
    Console.WriteLine($"Enter number [{i}]");
    arrayStats[i] = int.Parse(Console.ReadLine());

}

int sum = 0;
int max = arrayStats[0];
int min = arrayStats[0];


foreach (int x in arrayStats)
{
    sum += x;
    if (max < x)
    {
        max = x;
    }
    if (min > x)
    {
        min = x;
    }

}
float avg = sum / arrayStats.Length;

int[] arrayReversed = new int[arrayStats.Length];

for (int i = arrayStats.Length - 1; i >= 0; i--)
{
    arrayReversed[arrayStats.Length - 1 - i] = arrayStats[i];

}


Console.WriteLine($"sum = {sum}");
Console.WriteLine($"max = {max}");
Console.WriteLine($"min = {min}");
Console.WriteLine($"avg = {avg}");
Console.WriteLine($"reverse = {string.Join(", ", arrayReversed)}");
*/

//  QUESTION 3
/*
int students = 3;
int subjects = 4;

int[,] grades = new int[students, subjects];

// 1️⃣ Read grades
for (int i = 0; i < students; i++)
{
    Console.WriteLine($"Enter grades for Student {i + 1}:");

    for (int j = 0; j < subjects; j++)
    {
        Console.Write($"  Subject {j + 1}: ");
        grades[i, j] = int.Parse(Console.ReadLine());
    }
}

Console.WriteLine();
double classSum = 0;
int totalGrades = students * subjects;

for (int i = 0; i < students; i++)
{
    int studentSum = 0;

    for (int j = 0; j < subjects; j++)
    {
        studentSum += grades[i, j];
    }

    double studentAverage = (double)studentSum / subjects;
    classSum += studentSum;

    Console.WriteLine($"Student {i + 1} average = {studentAverage}");
}

double classAverage = classSum / totalGrades;
Console.WriteLine($"\nOverall class average = {classAverage}");

*/

//QUESTION 4
/*
class Program
{

    public static void Main(string[] args)
    {



        Console.WriteLine("Enter first number");
        double n1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Enter second number");
        double n2 = double.Parse(Console.ReadLine());


        Console.WriteLine("Choose an operation [+, -, *, /]");
        string op = Console.ReadLine();

        double result;

        switch (op)
        {
            case "+": result = Add(n1, n2); break;
            case "-": result = Subtract(n1, n2); break;
            case "*": result = Multiply(n1, n2); break;
            case "/": result = Divide(n1, n2); break;
            default: Console.WriteLine("Please Choose a valid operation"); return;
        }

        Console.WriteLine("Result = " + result);

    }


    static double Add(double n1, double n2)
    {

        return n1 + n2;
    }
    static double Subtract(double n1, double n2)
    {

        return n1 - n2;
    }
    static double Multiply(double n1, double n2)
    {

        return n1 * n2;
    }
    static double Divide(double n1, double n2)
    {

        return n1 / n2;
    }


}
*/

// QUESTION 5
/*
class Program {

public static void Main(string[] args)
    {

        double area, circumference;

        CalculateCircle(5, out area, out circumference);

        Console.WriteLine("Area = " + area);
        Console.WriteLine("Circumference = " + circumference);

    }

    public static void CalculateCircle(double radius, out double area, out double circumference)
    {
        area = Math.PI * radius * radius;
        circumference = 2 * radius * Math.PI;

    }
}
*/

// QUESTION 6

class Program
{
    public static void Main(string[] args)
    {

        int[] grades = new int[5];

        for(int i = 0; i<5; i++)
        {
            Console.WriteLine($"Please Enter Student {i+1} grade");
            grades[i] = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("--- Report ---");
        GetGrades(grades);

        float avg = Average(grades);

        Console.WriteLine($"Average :{avg}");
        int max;
        int min;
        GetMinMax(grades, out max, out min);
        Console.WriteLine($"Highest Scode: {max}");
        Console.WriteLine($"Lowest Scode: {min}");
        

    }

    public static void GetGrades(int[] grades) { 
    
        for(int i = 0; i<5; i++)
        {
            if (grades[i] >= 90) {
                Console.WriteLine($"Student {i+1}: {grades[i]} -> Grade:{Grades.A}");

            }
            else if (grades[i] >= 80){
                Console.WriteLine($"Student {i + 1}: {grades[i]} -> Grade:{Grades.B}");
            }
            else if (grades[i] >= 70){
                Console.WriteLine($"Student {i + 1}: {grades[i]} -> Grade:{Grades.C}");
            }
            else if (grades[i] >= 60){
                Console.WriteLine($"Student {i + 1}: {grades[i]} -> Grade:{Grades.D}");
            }
            else if (grades[i] < 60){
                Console.WriteLine($"Student {i + 1}: {grades[i]} -> Grade:{Grades.F}");
            }
            else { Console.WriteLine("Invalid Grade"); }
        }
    
    }

    public static float Average(int[] grades)
    {
        float sum = 0;
        for (int i = 0; i < 5; i++)
        {
            sum += grades[i];
        }
       return  sum = sum / grades.Length;
    }

    public static void GetMinMax(int[] grades , out int max , out int min)
    {
        max = grades[0];
        min = grades[0];
        foreach (int x in grades)
        {
            if (max < x)
            {
                max = x;
            }
            if (min > x)
            {
                min = x;
            }

        }
    }

}