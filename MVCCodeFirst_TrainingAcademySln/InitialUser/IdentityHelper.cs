using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using MVCCodeFirst_TrainingAcademySln.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst_TrainingAcademySln.InitialUser
{
    public class IdentityHelper
    {
        internal static void SeedIdentities(ApplicationDbContext context)
        {
            var userManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(context));
            if (!roleManager.RoleExists(InitialRole.ROLE_ADMINSTRATOR))
            {
                var roleResult = roleManager.Create(new IdentityRole(InitialRole.ROLE_ADMINSTRATOR));
                if (roleResult.Succeeded)
                {
                    string userName = "ovi@gmail.com";
                    string password = "@Ovi123";
                    ApplicationUser user = userManager.FindByName(userName);
                    if (user == null)
                    {
                        user = new ApplicationUser()
                        {
                            UserName = userName,
                            Email = userName,
                            EmailConfirmed = true
                        };
                        IdentityResult identityResult = userManager.Create(user, password);
                        if (identityResult.Succeeded)
                        {
                            var result = userManager.AddToRole(user.Id, InitialRole.ROLE_ADMINSTRATOR);
                        }
                    }
                }
            }
        }
    }
}