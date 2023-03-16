using Microsoft.AspNetCore.Identity;

namespace UserManagement.DAL.Models
{
    public class AppUserToken : IdentityUserToken<string>
    {
        public DateTime ExpireDate { get; set; }
    }
}
