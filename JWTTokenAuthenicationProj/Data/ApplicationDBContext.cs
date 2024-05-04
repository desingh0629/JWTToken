using JWTTokenAuthenicationProj.Model;
using Microsoft.EntityFrameworkCore;

namespace JWTTokenAuthenicationProj.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options) { }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
