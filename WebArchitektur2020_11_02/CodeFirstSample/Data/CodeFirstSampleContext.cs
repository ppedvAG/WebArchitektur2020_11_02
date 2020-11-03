using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeFirstSample.Models;

namespace CodeFirstSample.Data
{
    public class CodeFirstSampleContext : DbContext
    {
        public CodeFirstSampleContext (DbContextOptions<CodeFirstSampleContext> options)
            : base(options)
        {
        }

        public DbSet<CodeFirstSample.Models.Car> Car { get; set; }
    }
}
