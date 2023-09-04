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
        [TempData]
        public string StatusMessage { get; set; }
        [BindProperty]
        public IReadOnlyList<Report> Reports { get; set; }
        public ViewRawPageModel()
        {
        }
        public async Task OnGet()
        {
            // dirty deeds done dirty cheap
            StatusMessage = "";

            Reports = await DataOperations.Reports();

        }

        /// <summary>
        ///  * Get fresh list of contacts
        ///  * Crete Excel file with SpreadSheetLight
        ///  * Setup text for displaying success or failure
        ///  * Push back to same page were on document ready a dialog is displayed depended on success or failure for creating the excel file
        /// </summary>
        public async Task<PageResult> OnPostExportButton()
        {
            
            Reports = await DataOperations.Reports();

            StatusMessage = ExcelOperations.ExportToExcel(Reports) ? 
                "Report created <strong>successfully</strong>" : 
                "<strong>Failed</strong> to create report";


            return Page();

        }
    }
}
