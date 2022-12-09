using ExampleBlazorApp.Models;

namespace ExampleBlazorApp.Services
{
    public class ProductService
    {
        public static readonly List<Product> Products = new List<Product>()
        {
            new()
            {
                ID = 1,
                Name = "All roads lead to Blazor Server",
                Description = "A tutorial book for Blazer Server technology",
                Price = 70
            },
            new()
            {
                ID = 2,
                Name = "All roads lead to Blazor WASM",
                Description = "A tutorial book for Blazor WASM technology",
                Price = 70
            },
             new()
            {
                ID = 3,
                Name = "All roads lead to a place called earth",
                Description = "A tutorial book for life",
                Price = 70
            },
        };
    }
}
