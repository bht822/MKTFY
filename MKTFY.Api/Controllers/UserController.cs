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
        public ActionResult<IEnumerable<Customer>> GetUsers()
        {
           return _context.Customers.ToList();

        }
        [HttpGet("{id}")]
        public ActionResult<Customer> GetUser(int id)
        {
            return _context.Customers.Find(id);

        }
    }
}