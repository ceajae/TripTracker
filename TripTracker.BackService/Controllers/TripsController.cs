using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TripTracker.BackService.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TripTracker.BackService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripsController : ControllerBase
    {
        public TripsController(Repository repository)
        {
            _repository = repository;
        }

        private Repository _repository;

        // GET: api/<TripsController>
        [HttpGet]
        public IEnumerable<Trip> Get() 
        {
            return _repository.Get(); 
        }

        // GET api/<TripsController>/5
        [HttpGet("{id}")]
        public Trip Get(int id)
        {
            return _repository.Get(id);
        }

        // POST api/<TripsController>
        [HttpPost]
        public void Post([FromBody] Trip value)
        {
            _repository.Add(value);
        }

        // PUT api/<TripsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Trip value)
        {
            _repository.Update(value);
        }

        // DELETE api/<TripsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _repository.Remove(id);
        }
    }
}
