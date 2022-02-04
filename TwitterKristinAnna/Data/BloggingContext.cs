using Microsoft.EntityFrameworkCore;
using TwitterKristinAnna.Models;

namespace TwitterKristinAnna.Data
{
    public class BloggingContext: DbContext
    {
            public BloggingContext(DbContextOptions<BloggingContext> options) : base(options)
            {

            }

            public DbSet<Tweet> Tweet { get; set; }



        }
    }


