namespace EFCore_1;

internal class Program
{
    static void Main(string[] args)
    {

        using var dbContext = new AppDbContext();

        var book = new Book
        {
            Title = "The Great Gatsby",
            Price = 10,
            ISBNNumber = 123456789,
            NumberOfPages = 180,
            PublishYear = 1925,
            InStock = true
        };
        var author = new Author
        {
            FirstName = "F. Scott",
            LastName = "Fitzgerald",
            EmailAddress = "fscottfitzgerald@example.com",
            Biography = "F. Scott Fitzgerald was an American novelist and short story writer.",
            DateOfBirth = "1896-09-24"
        };

        var category = new Category
        {
            Name = "Classic Literature",
            Description = "Books that are considered classics in literature.",
            isActive = true
        };

        dbContext.Add(book);
        dbContext.Add(author);
        dbContext.Add(category);
        dbContext.SaveChanges();

    }
}
