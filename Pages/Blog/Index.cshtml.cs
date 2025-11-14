
using Microsoft.AspNetCore.Mvc.RazorPages;
using TB.Models;
using TB.Services;
using System.Collections.Generic;

namespace TB.Pages.Blog
{
    public class IndexModel : PageModel
    {
       public List<Article> Artigos { get; set; } = new(); // Lista para armazenar os artigos

        public void OnGet()
        {
            Artigos = ArticleRepository.GetAll();
        }
    }
}