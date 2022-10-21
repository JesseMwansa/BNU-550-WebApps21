using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace currencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]

        public string FullName { get; set; }
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }
        public void OnGet()
        {
            FullName = "Jesse Mwansa";
        }
        public void OnPost()
        {
            if(String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["NoName"] = "You have not entered a name!";
                FullName = "Anonymous";
            }
            else
            {
                ViewData["Message"] = "Name is registered!";
                // register the user
            }
        }
    }
}