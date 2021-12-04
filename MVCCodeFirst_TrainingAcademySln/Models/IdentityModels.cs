using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace MVCCodeFirst_TrainingAcademySln.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit https://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    
    public class ApplicationRole : IdentityRole
    {

        public ApplicationRole() : base() { }
        public ApplicationRole(string roleName) : base(roleName) { }
    }
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("TrainingDBContext", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Student> Students { get; set; }
        public virtual DbSet<Training> Trainings { get; set; }
        public virtual DbSet<Trainer> Trainers { get; set; }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        //public System.Data.Entity.DbSet<MVCCodeFirst_TrainingAcademySln.Models.RoleViewModel> RoleViewModels { get; set; }

        //public System.Data.Entity.DbSet<MVCCodeFirst_TrainingAcademySln.Models.RoleViewModel> RoleViewModels { get; set; }

        //public System.Data.Entity.DbSet<MVCCodeFirst_TrainingAcademySln.Models.RoleViewModel> RoleViewModels { get; set; }

        //public System.Data.Entity.DbSet<MVCCodeFirst_TrainingAcademySln.Models.RoleViewModel> RoleViewModels { get; set; }
    }
}