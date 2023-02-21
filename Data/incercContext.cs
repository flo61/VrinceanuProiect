using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using incerc.Models;

namespace incerc.Data
{
    public class incercContext : DbContext
    {
        public incercContext (DbContextOptions<incercContext> options)
            : base(options)
        {
        }

        public DbSet<incerc.Models.Book> Book { get; set; } = default!;

        public DbSet<incerc.Models.Publisher> Publisher { get; set; }

        public DbSet<incerc.Models.Genre> Genre { get; set; }

        public DbSet<incerc.Models.Shop> Shop { get; set; }
    }
}
