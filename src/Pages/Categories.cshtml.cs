using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorAPP.Pages
{
    public class CategoriesModel : PageModel
    {
        public List<Category> Categories { get; set; } = new();

        //Apenas para teste rapido
        List<Category> temp = new List<Category>();

        public void OnGet(int skip = 0, int take = 25)
        {
            for (var i = 0; i <= 1787; i++)
            {
                temp.Add(new Category(i,
                    $"Categoria {i}",
                    i * 18.95m));
            }

            //Apenas para teste rapido
            Categories = temp.Skip(skip).Take(take).ToList();
        }
    }

    public record Category(int id, string title, decimal price);
}
