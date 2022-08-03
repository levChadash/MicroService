using Microsoft.AspNetCore.Mvc;
using Ministry_of_Health.RabitMQ;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ministry_of_Interior.controllor
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitizenController : ControllerBase
    {
        private readonly IRabitMQProducer _rabitMQProducer;
        public CitizenController(IRabitMQProducer IRabitMQProducer)
        {
            _rabitMQProducer = IRabitMQProducer;
        }
        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public async Task<List<string>> GetCitizenById(string id)
        {
            if (id == null)
            {
                throw new ArgumentNullException("id");
            }
            var listId = new List<string>() { "212625917", "211837109" };
            var productData = listId.Where(l => l.Equals(id) == true).ToList();
            _rabitMQProducer.SendCitizens(productData);
            return productData;

        }

        // POST api/<ValuesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
