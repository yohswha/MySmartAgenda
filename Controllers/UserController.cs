using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MySmartAgenda.Dtos;
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
        private readonly IMapper _mapper;

        public UserController(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        [ProducesResponseType(200, Type =typeof(IEnumerable<User>))]
        public IActionResult GetUsers()
        {
            var user = _mapper.Map<List<UserDTO>>(_userRepository.GetUsers());
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);
        }

        [HttpGet("{Id}")]
        [ProducesResponseType(200, Type =typeof(IEnumerable<User>))]
        public IActionResult GetSingleUser(int Id)
        {
            var user =_mapper.Map<UserDTO> (_userRepository.GetSingleUser(Id));
            if(!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(user);
        }
    }
}

