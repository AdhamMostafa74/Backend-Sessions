using ADVNACED_C____02;


List<Product> catalog = new()
{
    new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 1200, Stock = 10 },
    new Product { Id = 2, Name = "Phone", Category = "Electronics", Price = 800, Stock = 25 },
    new Product { Id = 3, Name = "T-Shirt", Category = "Clothing", Price = 30, Stock = 100 },
    new Product { Id = 4, Name = "Jeans", Category = "Clothing", Price = 60, Stock = 50 },
    new Product { Id = 5, Name = "Chocolate", Category = "Food", Price = 5, Stock = 200 },
    new Product { Id = 6, Name = "Coffee Beans", Category = "Food", Price = 15, Stock = 80 },
    new Product { Id = 7, Name = "C# Book", Category = "Books", Price = 45, Stock = 30 },
    new Product { Id = 8, Name = "Novel", Category = "Books", Price = 20, Stock = 60 },
    new Product { Id = 9, Name = "Headphones", Category = "Electronics", Price = 150, Stock = 40 },
    new Product { Id = 10, Name = "Jacket", Category = "Clothing", Price = 120, Stock = 15 }
};

var electronics = Product.FilteredProducts(catalog, p => p.Category == "Electronics");
var cheap = Product.FilteredProducts(catalog, p => p.Price < 50);
var inStock = Product.FilteredProducts(catalog, p => p.Stock > 0);
var cheapClothing = Product.FilteredProducts(catalog,p => p.Category == "Clothing" && p.Price <= 50);

Console.WriteLine("--- Electronics ---");
PrintProducts(electronics);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("--- Under 50 ---");
PrintProducts(cheap);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("--- In Stock ---");
PrintProducts(inStock);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("--- Clothing Under $50 ---");
PrintProducts(cheapClothing);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("--- Short Report ---");
Product.LowStockAlert(catalog, p => Console.WriteLine($"{p.Name} - ${p.Price}"));
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("--- Detailed Report ---");
Product.LowStockAlert(catalog, 
    p => 
    Console.WriteLine($"[{p.Category}] {p.Name} " +
    $"| Price: ${p.Price} | Stock: {p.Stock}"));

Console.WriteLine();
Console.WriteLine();

Console.WriteLine("--- Summary List ---");
Product.TransformProducts(catalog, p => $"{p.Name} (${p.Price})");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("--- Price Labels ---");
Product.TransformProducts(catalog, p => p.Price > 100 ? $"{p.Name}: Expensive!" : $"{p.Name}: Affordable!");
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("--- Low-Stock Alert ---");
var lowStockProducts = Product.FilterLowStock(catalog, p => p.Stock < 20 );

foreach (Product result in lowStockProducts)
{
    Console.WriteLine($"[LOW STOCK] {result.Name}: only {result.Stock} left!");
}

Console.WriteLine();
Console.WriteLine();


static void PrintProducts (List<Product> products) {
    foreach (var product in products)
    {
        Console.WriteLine(product);
    }
}