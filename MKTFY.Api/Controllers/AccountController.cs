using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using IdentityModel.Client;
using MKTFY.App.Interface;
using MKTFY.Models.Entities;
using MKTFY.Models.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Authorization;

namespace MKTFY.Api.Controllers
{   
    [ApiController] 
   // [Route("account/[controller]")]
  //  [Authorize]
    public class AccountController: ControllerBase
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly IConfiguration _configuration;
        private readonly IUserRepository _userRepository;

        public AccountController(SignInManager<AppUser> signInManager,IConfiguration configuration,IUserRepository userRepository)
        {
            _signInManager = signInManager;
            _configuration = configuration;
            _userRepository = userRepository;

        }

        [HttpPost("account/login")]
        public async Task<ActionResult<LoginReponseVM>> Login([FromBody] LoginVM login)
        {
        
            if(!ModelState.IsValid)
                return BadRequest("Bad Data");
            
            var result = await _signInManager.PasswordSignInAsync(login.Email, login.Password,false, true).ConfigureAwait(false);

            if (result.IsLockedOut)
            {
                return BadRequest("This user has been locked out, please try again later");
                
            }else if (!result.Succeeded)
            {
                return BadRequest("Invalid username/password");
                
            }

            //Get the user profile

            var user = await _userRepository.GetUserByEmail(login.Email).ConfigureAwait(false);

            //Get a token from the identity server
            using (var httpClient = new HttpClient())
            {
                var authority = _configuration.GetSection("Identity").GetValue<string>("Authority");


                // Make the call to our identity server
                var tokenResponse = await httpClient.RequestPasswordTokenAsync(new PasswordTokenRequest
                {
                    Address = authority + "/connect/token",
                    UserName = login.Email,
                    Password = login.Password,
                    ClientId = login.ClientID,
                    ClientSecret = "3nn4Uq8LZ4ilUWfcHzWEjVvLvSouvwPy",
                    Scope = "MKTFYapi.scope",
                }).ConfigureAwait(false);

                if (tokenResponse.IsError)
                {
                    return BadRequest("tokenresponse is error");
                    
                }
                    

                return Ok(new LoginReponseVM(tokenResponse, user));
            }

        }
        
    }
}