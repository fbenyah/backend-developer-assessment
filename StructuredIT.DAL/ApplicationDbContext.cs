using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity.EntityFramework;
using StructuredIT.Models.User;

namespace StructuredIT.DAL
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("ApplicationContext", false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        #region Properties
            //public virtual DbSet<Models.Media.Genre> Genres { get; set; }
            //public virtual DbSet<Models.Media.MediaItem> MediaItems { get; set; }
        #endregion
    }
}
