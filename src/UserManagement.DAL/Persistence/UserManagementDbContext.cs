using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using UserManagement.DAL.Models;

namespace UserManagement.DAL.Persistence
{
    public class UserManagementDbContext : IdentityDbContext<AppUser>
    {
        public DbSet<AppUserToken> AppUserTokens { get; set; }

        public UserManagementDbContext(DbContextOptions<UserManagementDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.SeedData();
        }
    }

    public class UserManagementDbContextFactory : IDesignTimeDbContextFactory<UserManagementDbContext>
    {
        public UserManagementDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<UserManagementDbContext>();
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=UserManagementDb;User Id=admin;Password=sa1234;");

            return new UserManagementDbContext(optionsBuilder.Options);
        }
    }
}
