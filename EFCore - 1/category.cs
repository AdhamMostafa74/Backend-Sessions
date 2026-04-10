
namespace EFCore_1;

public class Category
{

    public int Id{ get; set; }
    public string Name{ get; set; }
    public string Description{ get; set; }
    public  IReadOnlyList<Book> Books{ get; set; }
    public bool isActive{ get; set; }

}
