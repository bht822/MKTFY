using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MKTFY.Models.Entities;
using MKTFY.Models.ViewModels;

namespace MKTFY.Api.Controllers
{
    [ApiController]
    [AllowAnonymous]

    public class RegisterController : ControllerBase
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RegisterController(UserManager<AppUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost("account/register")]
        public  async Task<ActionResult<RegisterResponseVM>> Register([FromBody] RegisterVM register)
        {

            if(!ModelState.IsValid)
                return BadRequest("Bad Data");

            var roleResult = await _roleManager.RoleExistsAsync("adminstrator");
            if(!roleResult)
            {
                await _roleManager.CreateAsync(new  IdentityRole("adminstrator"));

            }
            var userResult = await _userManager.FindByEmailAsync(register.Email.ToString());
            if(userResult == null)
            {
                var user = new AppUser
                {
                    UserName = register.Email.ToString(),
                    Email = register.Email.ToString(),
                    FirstName = register.FirstName,
                    LastName = register.LastName

                };

                IdentityResult result = await _userManager.CreateAsync(user, register.Password);

                if(result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(user,"adminstrator");
                    
                }
                

            }
            return Ok(true);




             



        }
    }
}