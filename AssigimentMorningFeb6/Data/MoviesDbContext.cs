using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssigimentMorningFeb6.Models;

namespace AssigimentMorningFeb6.Data
{
    public class MoviesDbContext : DbContext
    {
        public MoviesDbContext (DbContextOptions<MoviesDbContext> options)
            : base(options)
        {
        }

        public DbSet<AssigimentMorningFeb6.Models.Movie> Movie { get; set; } = default!;
    }
}
