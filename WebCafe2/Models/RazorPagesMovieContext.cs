using Microsoft.EntityFrameworkCore;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebCafe.Models
{
    public class RazorPagesMovieContext : DbContext
    {
        public RazorPagesMovieContext(
            DbContextOptions<RazorPagesMovieContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
    }
}
