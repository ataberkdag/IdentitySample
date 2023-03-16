using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserManagement.DAL.Models;
using UserManagement.DAL.Persistence;

namespace UserManagement.DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDAL(this IServiceCollection services, IConfiguration configuration)
        {
            ArgumentNullException.ThrowIfNull(services, nameof(services));

            services.AddDbContext<UserManagementDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("UserManagementDb")));
            services.AddIdentity<AppUser, IdentityRole>().AddEntityFrameworkStores<UserManagementDbContext>();

            services.Configure<IdentityOptions>(opt => {
                opt.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-._@+";
                opt.User.RequireUniqueEmail = true;
                opt.Password.RequiredLength = 5;
            });
            return services;
        }
    }
}
