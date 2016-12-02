using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace StructuredIT.Models.User
{
    public class ApplicationUser : IdentityUser
    {
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager, string authenticationType = "")
        {
            if (!string.IsNullOrEmpty(authenticationType))
            {
                return await manager.CreateIdentityAsync(this, authenticationType);
            }
            else
            {
                return await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            }
        }
    }
}
