using HidaaiAPI.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace HidaaiAPI.Data
{
    public class HidaaiDbContext:DbContext
    {
        public HidaaiDbContext(DbContextOptions<HidaaiDbContext> dbContextOptions):base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
    }
}
