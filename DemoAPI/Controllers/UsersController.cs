using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DemoAPI.Models;

namespace DemoAPI.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        // GET: /users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return new User[]
            {
              new User() { ID = 1, Name = "Hugo" },
              new User() { ID = 2, Name = "AJ" }
            };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
