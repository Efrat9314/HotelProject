using Microsoft.AspNetCore.Mvc;
using HotelProject.API;
using HotelProject.Core.Repositories;
using HotelProject.Core.Entities;
using HotelProject.API.Models;
using AutoMapper;
using HotelProject.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICusromerService _customerService;
        private readonly IMapper _mapper;
        
        public CustomersController( ICusromerService cusromerService,IMapper mapper)
        {
            _customerService = cusromerService;
            _mapper = mapper;
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
        public ActionResult Post([FromBody] CustomerPostModel c)
        {
            Customer customer = new Customer { CustomerId=c.CustomerId,Name=c.Name,Phone=c.Phone,Adress =c.Adress,Email=c.Email};
            _customerService.Post(customer);
           return Ok(_mapper.Map<CustomerDto>(customer));

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
