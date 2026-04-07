//using static LINQ.DataSources.Source;
using LINQ.DataSources;
using LINQ.Models;
using System.Reflection.Emit;

namespace LINQ;

	internal class Program
{
    static void Main(string[] args)
    {

        var products = Source.ProductList;
        var customer = Source.CustomerList;


        //question 1

        //var top3ExpensiveProducts = products
        //	.OrderByDescending(p => p.UnitPrice)
        //	.Take(3)
        //	.Select(p => new { p.ProductName, p.UnitPrice});

        //Print(top3ExpensiveProducts);


        //question 2

        //var secondPageProducts = products
        //	.OrderBy(p => p.ProductID)
        //	.Skip(5)
        //	.Take(5)
        //             .Select(p => new { p.ProductName, p.UnitPrice });

        //Print(secondPageProducts);


        //question 3

        //var productsLessThan25 = products
        //	.OrderBy(p => p.UnitPrice)
        //	.TakeWhile(p => p.UnitPrice < 25)
        //             .Select(p => new { p.ProductName, p.UnitPrice });
        //Print(productsLessThan25);


        //question 4

        //var inStockSeefoodProducts = products
        //	.Where(p => p.Category.Equals("Seafood", StringComparison.OrdinalIgnoreCase))
        //	.Any(p => p.UnitsInStock > 0);


        //question 5

        // int[] ids = { 3, 9, 13, 18 };

        //var test = ids.Contains(9);

        // Console.WriteLine(test);



        //question 6

        //var groupedProducts = products

        //    .GroupBy(p => p.Category)
        //    .Select(g => new {
        //        Category = g.Key,
        //        numberOfProducts = g.Count()
        //    });
        //Print(groupedProducts);




        //qeustion 7

        //var groupedProductsNames = products
        //    .GroupBy(p => p.Category)
        //    .SelectMany (g =>
        //                g.Select(p => p.ProductName))
        //    ;

        //Print(groupedProductsNames);



        //question 8

        //var categoriesWithMoreThan3Products = products
        //    .GroupBy(p => p.Category)
        //    .Where(g => g.Count() > 3)
        //    .Select(g => g.Key);

        //Print(categoriesWithMoreThan3Products);


        //question 9

        //var customerByCountry =
        //    from c in customer
        //    group c by c.Country into cg
        //    select new
        //    {
        //        Country = cg.Key,
        //        Count = cg.Count(),
        //        TotalOrderValue = 
        //              cg.Sum(c => c.Orders.
        //                 Sum(o => o.Total))

        //    };

        //Print(customerByCountry);


        //question 10

        //var totalNumberOfUnits = products
        //    .Sum(p => p.UnitsInStock);


        //Console.WriteLine(totalNumberOfUnits);


        //question 11

        //var cheapestProduct = products
        //    .OrderBy(p => p.UnitPrice)
        //    .First();
        //var mostExpensiveProduct = products
        //    .OrderByDescending(p => p.UnitPrice)
        //    .First();


        //quesiton 12

        //var distinctCategories = products
        //    .Select(p => p.Category)
        //    .Distinct();


        //question 13 

        //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
        //int[] setB = { 3, 6, 9, 12, 15, 13 };

        //var notInSetB = setA.Except(setB);


        //question 14

        //string[] list1 = { "Germany", "France", "UK", "Spain" };
        //string[] list2 = { "france", "SPAIN", "Italy" };

        //var notInList2 = list1.Except(list2 , StringComparer.OrdinalIgnoreCase);


        //question 15

        //var productDictionary = products
        //     .ToDictionary(p => p.ProductID);

        //var product = productDictionary[18];

        //quesiton16

        //var firstProduct = products
        // .First(p => p.UnitPrice > 50);


        //question 17

        //var firstProductOver500 = products
        //.FirstOrDefault(p => p.UnitPrice > 500);



        //question 18

        // var table = Enumerable.Range(1, 19)
        //   .Select(i => 7 * i);

        //Print(table);

        //question  19 

        //var evens = Enumerable.Range(1, 30)
        //     .Where(n => n % 2 == 0);

        //Print(evens);

        //quesiton 20 

        //var concatedProductNames = products
        //    .Take(3)
        //    .Select(p => p.ProductName)
        //    .Concat(
        //        customer
        //            .Take(3)
        //            .Select(c => c.CompanyName)
        //    );



        //quesiton 21 

        var pairedProducts = products
    .Zip(customer, (p, c) => $"{p.ProductName} sold to {c.CompanyName}");

    }




    public static void Print<T>(IEnumerable<T> products)
		{
        foreach (var product in products)
        {
            Console.WriteLine(product);

        }
      
				
		}
	}
