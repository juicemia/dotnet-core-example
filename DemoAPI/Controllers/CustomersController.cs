using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using DemoAPI.Models;

namespace DemoAPI.Controllers
{
    [Route("users")]
    public class CustomersController : Controller
    {
        // GET: /users
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            using (CustomerContext Context = new CustomerContext())
            {
              return Context.Customers.ToList();
            }
        }

        // POST: /users/new
        [HttpPost("new")]
        public Customer NewCustomer(Customer newCustomer)
        {
          using (CustomerContext Context = new CustomerContext())
          {
            Context.Customers.Add(newCustomer);
            Context.SaveChanges();
          }

          return newCustomer;
        }
    }
}
