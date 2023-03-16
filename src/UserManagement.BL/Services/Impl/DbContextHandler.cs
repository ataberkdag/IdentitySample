using Microsoft.EntityFrameworkCore;
using UserManagement.BL.Services.Interfaces;
using UserManagement.DAL.Persistence;

namespace UserManagement.BL.Services.Impl
{
    public class DbContextHandler : IDbContextHandler
    {
        private readonly UserManagementDbContext _context;

        public DbContextHandler(UserManagementDbContext context)
        {
            _context = context;
        }

        public DbSet<T> GetDbSet<T>() where T : class
        {
            return _context.Set<T>();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
