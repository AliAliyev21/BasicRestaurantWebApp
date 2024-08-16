using Microsoft.EntityFrameworkCore;
using WebApplication3.Entities;

namespace WebApplication3.Data
{
    public class ProductDbContext:DbContext
    {
       public ProductDbContext(DbContextOptions<ProductDbContext> options) 
            : base(options) { }

        public DbSet<Product> Products { get; set; }
    }
}
