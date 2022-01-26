using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Movies4Joel.Models
{
    public class MovieFormContext : DbContext
    {
       public MovieFormContext (DbContextOptions<MovieFormContext> options) : base (options) //constructor
       {
            
       }

       public DbSet<ApplicationResponse> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<ApplicationResponse>().HasData(

                new ApplicationResponse
                {
                    MovieID = 1,
                    Category = "Action",
                    Title = "Dark Knight Rises",
                    Year = 2008,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Batman's a cool guy"   
                },
                new ApplicationResponse
                {
                    MovieID = 2,
                    Category = "Action/Advneture",
                    Title = "Spider-Man: No Way Home",
                    Year = 2021,
                    Director = "Jon Watts",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new ApplicationResponse
                {
                    MovieID = 3,
                    Category = "Action/Sci-fi",
                    Title = "Inception",
                    Year = 2010,
                    Director = "Christopher Nolan",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = "Another Nolan banger"
                }
            );
        }
    }
}
