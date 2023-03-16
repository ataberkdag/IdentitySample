using Microsoft.EntityFrameworkCore;

namespace UserManagement.BL.Services.Interfaces
{
    public interface IDbContextHandler
    {
        public DbSet<T> GetDbSet<T>() where T : class;
        public Task SaveChangesAsync();
    }
}
