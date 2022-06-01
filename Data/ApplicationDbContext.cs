using Microsoft.EntityFrameworkCore;
using woww.Models;


namespace woww.Data 
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):
        base(options)
        {
            
        }

        public DbSet<Item> Items { get; set; }

         public DbSet<Type> Types { get; set; }
    }
}