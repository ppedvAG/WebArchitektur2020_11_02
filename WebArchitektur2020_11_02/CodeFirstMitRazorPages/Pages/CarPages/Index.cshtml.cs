using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CodeFirstMitRazorPages.Data;
using CodeFirstMitRazorPages.Models;

namespace CodeFirstMitRazorPages.Pages.CarPages
{
    public class IndexModel : PageModel
    {
        private readonly CodeFirstMitRazorPages.Data.CodeFirstMitRazorPagesContext _context;

        public IndexModel(CodeFirstMitRazorPages.Data.CodeFirstMitRazorPagesContext context)
        {
            _context = context;
        }

        public IList<Car> Car { get;set; }

        public async Task OnGetAsync()
        {
            Car = await _context.Car.ToListAsync();
        }
    }
}
