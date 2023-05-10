using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HidaaiAPI.Data
{
    public class HidaaiAuthDbContext : IdentityDbContext
    {
        public HidaaiAuthDbContext(DbContextOptions<HidaaiAuthDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            var readerRoleId = "8ee28108-e62b-4552-ac5c-1195e7637ab4";
            var writerRoleId = "2ac4c0c0-839e-4d79-9913-ff16463f4887";

            var roles = new List<IdentityRole>
            {
               new IdentityRole
               {
                   Id = readerRoleId,
                   ConcurrencyStamp=readerRoleId,
                   Name="Reader",
                   NormalizedName="Reader".ToUpper()
               },
               new IdentityRole
               {
                   Id = writerRoleId,
                   ConcurrencyStamp=writerRoleId,
                   Name="Writer",
                   NormalizedName="Writer".ToUpper()
               }
            };
            builder.Entity<IdentityRole>().HasData(roles);
        }
    }
}
