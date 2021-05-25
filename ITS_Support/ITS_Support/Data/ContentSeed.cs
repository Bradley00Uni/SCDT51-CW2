using ITS_Support.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ITS_Support.Data
{
    public static class ContentSeed
    {
        public static async Task SeedRolesAsync(UserManager<UserModel> userManager, RoleManager<IdentityRole> roleManager)
        {
            //Seed Roles
            await roleManager.CreateAsync(new IdentityRole(Roles.Admin.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Manager.ToString()));
            await roleManager.CreateAsync(new IdentityRole(Roles.Support.ToString()));
        }

        public static async Task SeedSystemAdminAsync(UserManager<UserModel> userManager, RoleManager<IdentityRole> roleManager)
        {
            var defaultUser = new UserModel
            {
                UserName = "SystemAdmin",
                Email = "systemadmin@gmail.com",
                FirstName = "Bradley",
                Surname = "De'Ath",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true
            };
            
            if (userManager.Users.All(u => u.Id != defaultUser.Id))
            {
                var user = await userManager.FindByEmailAsync(defaultUser.Email);
                if (user == null)
                {
                    await userManager.CreateAsync(defaultUser, "SystemP@ssword1");
                    await userManager.AddToRoleAsync(defaultUser, Roles.Admin.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Manager.ToString());
                    await userManager.AddToRoleAsync(defaultUser, Roles.Support.ToString());
                }
            }
        }
    }
}
