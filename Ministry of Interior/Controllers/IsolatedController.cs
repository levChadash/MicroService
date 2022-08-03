using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ministry_of_Interior.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IsolatedController : ControllerBase
    {
        // GET: api/<IsolatedController>
        [HttpGet]
        public void SendEmailAboutQuarantine()
        {
            List<string> result = new List<string>();
            for (int i = 0; i <result.Count(); i++)
            {
                string patient=result[i];

                string send = $"hi {patient} you need to be in quarantine";
                Console.WriteLine(send);

            } 
        }

        // GET api/<IsolatedController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IsolatedController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IsolatedController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IsolatedController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
