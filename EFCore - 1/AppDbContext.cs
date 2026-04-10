
using Microsoft.EntityFrameworkCore;

namespace EFCore_1;

public class AppDbContext: DbContext

{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {


        optionsBuilder.UseSqlServer("Server=.;Database=ReadMoreBooks;Trusted_Connection=True;TrustServerCertificate = true");

    }

    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Category> Categories { get; set; }
}
