using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using ProjektKrypto2.Components.Models;

namespace ProjektKrypto2.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<CryptoWallet> CryptoWallets { get; set; }
        public DbSet<UserBalance> UserBalances { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<UserBalance>()
                .HasKey(ub => ub.UserId);
        }
    }
}
