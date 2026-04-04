//using static LINQ.DataSources.Source;
using LINQ.DataSources;
using LINQ.Models;

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{

			var products = Source.ProductList;

			//question 1

			//var seaFoodProducts = Source.ProductList
			//	.Where(p => p.Category == "Seafood");

			//Print(seaFoodProducts);


			//question 2

			//var productsName = Source.ProductList
			//	.Select(p => p.ProductName);

			//Print(productsName);


			//question 3

			//var productsAscendedPrice = products
			//	.OrderBy(p => p.UnitPrice)
			//	.Select(p => new { p.ProductName, p.UnitPrice });

			//Print(productsAscendedPrice);


			//question 4

			//var productsWithPriceBetween10To30 = products
			//	.Where(p => p.UnitPrice <= 30 && p.UnitPrice >= 10);


			//Print(productsWithPriceBetween10To30);



			//quesiton 5

			//var productsInStock = products
			//	.Where(p => p.UnitsInStock > 0 && p.Category == "Condiments");

			//Print(productsInStock);

			//question 6

			//var anonymousProductType = new[] {
			//	new { Name = "Laptop" , Price = 50000.0m , StockStatus = 40 },
			//	new { Name = "TV" , Price = 20000.0m, StockStatus = 12 },
			//	new { Name = "Phone" , Price = 12000.0m, StockStatus = 0 }
			//}.Where(p => p.StockStatus > 0)
			//.Select(p => new
			//{
			//	  p.Name,
			//	  p.Price,
			// 	  Stock = p.StockStatus > 0 ? "Available" : "Out of Stock"
			//});

			//Print(anonymousProductType);

			//question 7

			//var numberedProducts = products
			//	.Select((p, index) => new
			//	{
			//		 $"{index + 1}. {p.ProductName} "
			//	});

			//Print(numberedProducts);


			//question 8 

			//var sortedCategories = products
			//	.OrderBy(c => c.Category )
			//	.ThenByDescending(p => p.UnitPrice)
			//	.Select(p => p);

			//Print(sortedCategories);


			//question 9

			//var beverages = products
			//.Where(p => p.Category == "Beverages")
			//.OrderByDescending(p=> p.UnitsInStock)
			//.Select(p => new { p.ProductName, p.UnitsInStock });

			//   Print(beverages);


			//question 10 


			//var orderHistory =
			//	from c in Source.CustomerList
			//	from o in c.Orders
			//	where o.OrderDate >= new DateTime(1997, 1, 1)
			//	select new
			//	{
			//		CustomerId = c.CustomerID,
			//		Orderdate = o.OrderDate
			//	};

			//Print(orderHistory);


			//question 11

			var orderedStringArr = new[]{ "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

			var sortedWords =
				from word in orderedStringArr
				orderby word.Length, word.ToLower()
				select word;

			Print(sortedWords);



		}
		public static void Print<T>(IEnumerable<T> products)
		{
			foreach (var product in products)
				Console.WriteLine(product);
		}
	}
}
