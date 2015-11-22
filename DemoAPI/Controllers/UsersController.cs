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
            using (UserContext Context = new UserContext())
            {
              return Context.Users.ToList();
            }
        }
    }
}
