using Microsoft.AspNetCore.Mvc;
using MySmartAgenda.Interfaces;
using MySmartAgenda.Models;
using MySmartAgenda.Repositories;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySmartAgenda.Controllers
{
    [Route("api /[controller]")]
    [ApiController]

    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        

        [HttpGet]
        [ProducesResponseType(200, Type =typeof(IEnumerable<User>))]
        public IActionResult GetUsers()
        {
            var user = _userRepository.GetUsers();
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);
        }
    }
}

