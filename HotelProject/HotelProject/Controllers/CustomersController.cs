using Microsoft.AspNetCore.Mvc;
using HotelProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private static List<Customer> customerList = new List<Customer>();

        // GET: api/<CustomersController>
        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            return customerList;
        }

        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        public Customer Get(string id)
        {
            return customerList.Find(x=> x.CustId==id);
        }

        // POST api/<CustomersController>
        [HttpPost]
        public void Post([FromBody] Customer c)
        {
            Customer c1=new Customer { CustId=c.CustId,Name=c.Name,Email=c.Email,Phone=c.Phone,Adress=c.Adress };
            customerList.Add(c1);
        }

        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] Customer c)
        {
            Customer c1 = customerList.Find(x => x.CustId==id);
            c1.Name=c.Name;
            c1.Email=c.Email;
            c1.Phone=c.Phone;
            c1.Adress=c.Adress;
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            Customer c1 = customerList.Find(x => x.CustId == id);
            customerList.Remove(c1);
        }
    }
}
