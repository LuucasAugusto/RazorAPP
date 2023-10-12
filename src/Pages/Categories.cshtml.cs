using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAPP.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public void OnGet()
        {
            for (var i = 0; i <= 100; i++)
            {
                Categories.Add(new Category(i,
                    $"Categoria {i}",
                    i * 18.95m));
            }
        }
    }

    public record Category(int id, string title, decimal price);
}
