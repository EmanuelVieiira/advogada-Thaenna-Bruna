
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using TB.Models;
using TB.Services;

namespace TB.Pages.Blog
{
    public class ArticleModel : PageModel
    {
        public Article? Artigo { get; set; }  // ? fez a diferença aqui

        public IActionResult OnGet(string slug)
        {
            if (string.IsNullOrEmpty(slug))
                return RedirectToPage("/Blog/Index");

            Artigo = ArticleRepository.GetBySlug(slug);

            if (Artigo == null)
                return NotFound();

            return Page();
        }
    }
}