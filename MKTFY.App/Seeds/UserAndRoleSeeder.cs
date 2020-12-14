using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MKTFY.Models.Entities;

namespace MKTFY.App.Seeds
{
    public static class UserAndRoleSeeder
    {
        public static async Task SeedUsersAndRoles(RoleManager<IdentityRole> roleManager, UserManager<AppUser> userManager)
        {
            var roleResult = await roleManager.RoleExistsAsync("administrator");
            if (!roleResult)
            {
                await roleManager.CreateAsync(new IdentityRole("administrator"));
            }

            var userResult = await userManager.FindByNameAsync("test+admin@launchpadbyvog.com");
            if (userResult == null)
            {
                var user = new AppUser
                {
                    UserName = "test+admin@launchpadbyvog.com",
                    Email = "test+admin@launchpadbyvog.com",
                    FirstName = "Test",
                    LastName = "Admin",
                };
                IdentityResult result = await userManager.CreateAsync(user, "Password1");

                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, "administrator");
                }
            }
        }
        
    }
}