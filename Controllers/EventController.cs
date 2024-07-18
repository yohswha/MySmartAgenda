using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MySmartAgenda.Dtos;
using MySmartAgenda.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MySmartAgenda.Controllers
{
    [Route("api/[controller]")]
    public class EventController : Controller
    {
        private readonly EventRepository _eventRepository;
        private readonly IMapper _mapper;

        public EventController(EventRepository eventRepository, IMapper mapper)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        // GET: api/values
        [HttpGet]
        public IActionResult GetEvents()
        {
            var evento = _mapper.Map<List<EventDTO>>(_eventRepository.GetEvents());
            if (!ModelState.IsValid)
                return BadRequest(ModelState);
            return Ok(evento);
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

