using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SDEVTest.Models;

namespace SDEVTest.Data
{
    public class SDEVTestContext : DbContext
    {
        public SDEVTestContext (DbContextOptions<SDEVTestContext> options)
            : base(options)
        {
        }

        public DbSet<SDEVTest.Models.Stock> Stock { get; set; }
    }
}
