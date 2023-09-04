using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;
using Serilog;
using ShadowProperties.Classes;
using ShadowProperties.Models;
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

#pragma warning disable CS8601

namespace HasQueryFilterRazorApp.Pages
{
    
    public class ViewRawPageModel : PageModel
    {
        [BindProperty]
        public List<Report> Reports { get; set; }
        public ViewRawPageModel()
        {
        }
        public async Task OnGet()
        {
            Reports = await DataOperations.Reports();
        }
    }
}
