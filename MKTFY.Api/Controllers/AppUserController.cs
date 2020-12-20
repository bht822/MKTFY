using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MKTFY.App;
using MKTFY.Models.Entities;

namespace MKTFY.Api.Controllers
{

    [ApiController]
  // [Route("api/[controller]")]
    [Authorize(AuthenticationSchemes = "Bearer")]

    public class AppUserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public AppUserController(ApplicationDbContext context){
            _context = context;

        }
        
        [HttpGet("api/users")]
       // [Authorize(AuthenticationSchemes = "Bearer")]
        public ActionResult<IEnumerable<AppUser>> GetUsers()
        {
            return  _context.Users.ToList();
            
            
        }

        
    }
}