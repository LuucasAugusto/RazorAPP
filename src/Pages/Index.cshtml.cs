using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAPP.Pages
{
    public class IndexModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        public async Task OnGet()
        {
            await Task.Delay(1000);

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
