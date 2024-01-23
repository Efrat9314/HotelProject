using Microsoft.AspNetCore.Mvc;
using HotelProject.API;
using HotelProject.Core.Repositories;
using HotelProject.Core.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICusromerService _customerService;
        
        public CustomersController( ICusromerService cusromerService)
        {
            _customerService = cusromerService;
        }
        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return _customerService.Get();
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(string id)
        {
            return Ok(_customerService.GetById(id));
        }

        // POST api/<CustomersController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer c)
        {
            _customerService.Post(c);
            return Ok();

        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Customer c)
        {
            _customerService.Put(id, c);
            return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            _customerService.Delete(id);
            return Ok();
        }
    }
}
