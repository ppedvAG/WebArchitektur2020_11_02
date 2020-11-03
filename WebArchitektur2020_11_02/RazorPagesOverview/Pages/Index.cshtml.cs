using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesOverview.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;


        public string Name { get; set; } = "no name";
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }


        //OnGet wird aufgerufen wenn ich auf https://localhost:12345/
        //Mithilfe von OnGet kann ich Initialisierungen vornehmen
        public void OnGet()
        {
            Name = "Hallo Thomas";
        }
    }
}
