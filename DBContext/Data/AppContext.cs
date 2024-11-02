using DBContexts.Entity;
using Microsoft.EntityFrameworkCore;

namespace DBContexts.Data
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base( options) { }

        public DbSet<Drincs> Drincs { get; set; } 
        public DbSet<RFoods> Foods { get; set; } 
        public DbSet<Ice_Creams> Creams { get; set; }
    }
}
