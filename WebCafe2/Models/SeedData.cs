using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Model.Model;
namespace WebCafe.Models
{

    public class SeedData 
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMovieContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMovieContext>>()))
            {
                // Look for any movies.
                if (context.Categories.Any())
                {
                    return;   // DB has been seeded
                }

                context.Categories.AddRange(
                    new Category
                    {
                        CategoryName = "Entity Framework",
                        Description = "All post in Entity Framework",
                        UrlSlug = "entity framework"
                    },
                     new Category
                     {
                         CategoryName = "Entity Framework 2",
                         Description = "All post in Entity Framework 2",
                         UrlSlug = "entity framework 2"
                     }


                );
                context.SaveChanges();
            }
        }
    }
}
