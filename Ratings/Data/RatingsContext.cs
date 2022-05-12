using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ratings.Models;

namespace Ratings.Data
{
    public class RatingsContext : DbContext
    {
        public RatingsContext (DbContextOptions<RatingsContext> options)
            : base(options)
        {
        }

        public DbSet<Ratings.Models.RatingObj>? RatingObj { get; set; }
    }
}
