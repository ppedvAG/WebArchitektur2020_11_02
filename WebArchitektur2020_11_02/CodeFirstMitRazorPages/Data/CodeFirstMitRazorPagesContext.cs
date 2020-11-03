using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstMitRazorPages.Models;

namespace CodeFirstMitRazorPages.Data
{
    public class CodeFirstMitRazorPagesContext : DbContext
    {
        public CodeFirstMitRazorPagesContext (DbContextOptions<CodeFirstMitRazorPagesContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirstMitRazorPages.Models.Car> Car { get; set; }
    }
}
