namespace Advanced_C_;

public class Program
{
    static void Main(string[] args)
    {
      
    
    }


#region

/*
 QUESTION 1

    A generic class is a classthat uses type parameters T
    which will be replaced by the actual parametes in runtime when an instance is created

    Because it allows us multiple benefits such as type safety ,code reusability 
    performance and flexibility


 */

// Question 2 >> Container.Cs class 


// Question 3 >> Pair.Cs class


// Question 4 >>

/* A generic method is a method that uses type parameters which will also be replaced 
by the actual parameters in runtime when the method is called 
*/

public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}


// Question 5 >> Container.Cs class

// QUESTION 6 

/*
 Generic interfaces are contracts that define set of methods with type parameters that must be 
 implemented by a calss that specifies the type when implementing 
 */

/*
 
    QUESTION 7 

A STRUCT CONSTRAINT IS A CONSTRAINT WHERE THE TYPE PARAMETS MUST ADHERE TO THE STRUCT TYPE 
IMPLEMENTING ITS BEHAVIORS AND PROPERTIES 
 
public T AddNumbers<T>(T n1, T n2) where T : struct
{
    return n1 + n2;
}

here the type parameter will implement the struct + operator to add the numbers 
 */


/*
 
 QUESTION 8

A CLASS CONSTRAINT IS THE SAME LIKE THE STRUCT BUT INSTEAD IN ADHERES TO THE CLASS TYPE

 
public T AddString<T>(T n1, T n2) where T : class
{
    return n1 + n2;
}

 here the operator will implement the class + operator instead to concat the strings
 */

/*
 
 QUESTION 9

 A NEW() CONSTRAINT IS IS WHERE THE TYPE PARAMETER MUST HAVE A DEFAULT CONSTRUCTOR TO BE INSTANTIATED 
 
public T CreateInstance<T>() where T : new()

 */

/* QUESITON 10
 
 AN INTERFACE CONSTRAINT IS WHERE THE TYPE PARAMETER MUST IMPLEMENT A SPECIFIC INTERFACE TO BE USED

public T CloneRepo<T>() where T : IRepository<T>

*/


/*
 
    QUESTION 11

A BASE CLASS CONSTRAINT IS WHERE THE TYPE PARAMETER MUST INHERIT FROM A SPECIFIC BASE CLASS TO BE USED

 public void Eat() where T : BaseClass
    {
        Console.WriteLine("Eating...");
    }

 */

/*
 
QUESTION 12

where T : Constraint1, Constraint2, Constraint3

public class DogActivity <T>
    where T : Animal, IRun, new()
{
    public T CreateAndProcess()
    {
        T obj = new T();
        obj.Eat();
        obj.Run();
        return obj;
    }
}

 
 */


/*
 
        QUESTION 13

        Default keyword is used to return the default value of the type parameter 
        if its a reference type it'll return null if its a value type it'll return 0 or false 

 */

/*
    QUESTION 14 IN CONTAINER.CS CLASS
        
 
 */

/*
 QUESTION 15 

Covariance means we can use a more derived type where a base type is expected

The out keyword tells C# that a generic type is output only you only return it not accept it as input
 
 
 */

/*
 
 QUESTION 16

Contravariance is the opposite we can use a base type where a derived type is expected.

The in keyword means the generic type is input only we pass values into it not return them
 
 */


/*
 
 QUESTION 17
covariance allows derived type to base type and its used when type is returned only
contravariance allows base to derived type type its used when type is derived type
 */


/*
 
 QUESTION 18

static members belong to the specific generic type created not to the generic definition itself
which means each type gets its own static copy
 
 */


/*
 
 QUESTION 19

 we inherit from a generic class the same way we inherit from a normal class
but we include the type parameter.
 */
#endregion
