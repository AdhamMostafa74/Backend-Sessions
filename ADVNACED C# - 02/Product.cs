namespace ADVNACED_C____02;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Category { get; set; } = null!; 
    public double Price { get; set; }
    public int Stock { get; set; }

    // in this method I used FUNC because I wanted to return a search result based on multiple criteria 
    public static List<Product> FilteredProducts(List<Product> products , Func<Product, bool> filter ) {

        var result = new List<Product>();

        foreach (Product product in products) {

            if (filter(product))
            {
                result.Add(product);
            }
        }
        return result;
    }

    // here I didnt need to return anything so action was good
    public static void LowStockAlert(List<Product> products, Action<Product> reportType) {

        foreach (Product product in products) {

            if(product.Stock <= 50)
            {
                reportType(product);

            }

        }
    
    }

    // I wanted to return a string based on the need of the user 
    public static void TransformProducts(List<Product> products, Func<Product, String> transformer) {

        foreach (Product product in products)
        {
            Console.WriteLine(transformer(product));
        }
    }


    public static List<Product> FilterLowStock(List<Product> products, Predicate<Product> filterType) {

        List<Product> results = [];
        foreach(Product product in products)
        {
            if (filterType(product))
            {
                results.Add(product);
            }
        }
       
        return results;
    }

    public override string ToString()
    {
        return $"Name - {Name} - Price = ${Price} - (Stock: {Stock})";
    }
}