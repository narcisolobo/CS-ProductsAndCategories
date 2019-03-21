using Microsoft.EntityFrameworkCore;

namespace ProductsAndCategories.Models {
    public class PNCContext : DbContext {
        public PNCContext(DbContextOptions<PNCContext> options) : base(options) { }
        public DbSet<Product> Products {get;set;}
        public DbSet<Category> Categories {get;set;}
        public DbSet<Association> Associations {get;set;}
    }
}