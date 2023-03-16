using UserManagement.DAL.Models;

namespace UserManagement.BL.Services.Interfaces
{
    public interface IAccessTokenService
    {
        public Task<DAL.Models.AppUserToken> GetToken(AppUser appUser, List<string> userRoles);
        public Task DeleteToken(AppUser appUser);
    }
}
