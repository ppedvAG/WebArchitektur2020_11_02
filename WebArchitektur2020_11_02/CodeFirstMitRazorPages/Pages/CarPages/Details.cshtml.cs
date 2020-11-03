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
    public class DetailsModel : PageModel
    {
        private readonly CodeFirstMitRazorPages.Data.CodeFirstMitRazorPagesContext _context;

        public DetailsModel(CodeFirstMitRazorPages.Data.CodeFirstMitRazorPagesContext context)
        {
            _context = context;
        }

        public Car Car { get; set; }

        public async Task<IActionResult> OnGetAsync(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Car = await _context.Car.FirstOrDefaultAsync(m => m.Id == id);

            if (Car == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
