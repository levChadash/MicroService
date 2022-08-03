using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Airport.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PassengersController : ControllerBase
    {
        // GET: api/<PassengersController>
        [HttpGet]
        public List<string> GetAllPassengers()
        {
            return new List<string>(){ "212625917","211837109"};
        }

        // GET api/<PassengersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PassengersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<PassengersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PassengersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
