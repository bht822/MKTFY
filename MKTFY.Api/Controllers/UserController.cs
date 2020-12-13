using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using MKTFY.App;
using MKTFY.Models.Entities;

namespace MKTFY.Api.Controllers
{

    public class UserController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        public UserController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetUsers()
        {
           return _context.AppUsers.ToList();

        }
        [HttpGet("{id}")]
        public ActionResult<User> GetUser(int id)
        {
            return _context.AppUsers.Find(id);

        }
    }
}