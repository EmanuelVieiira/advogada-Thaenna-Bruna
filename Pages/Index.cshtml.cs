using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TB
{
    public class IndexModel : PageModel
    {
        public string DataFormatada { get; set; } = "";

        public void OnGet()
        {
            DataFormatada = DateTime.Now.ToString("dd 'de' MMMM, yyyy");
        }
    }
}

