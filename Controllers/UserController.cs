using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MySmartAgenda.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySmartAgenda.Controllers
{
    public class UserController : Controller
    {
        private static List<User> userList = new List<User>
        {
            new User
            {Id=1,
             Name="Yohswha",
             LastName="Bello",
             Email="yoh@gmail.com"
            }
        };
        //[ApiController]
        [Route("api /[controller]")]
        // GET: /<controller>/



        [HttpGet]
        public async Task<ActionResult<List<User>>> GetAll()
        {
            return userList;
        }
    }
}

