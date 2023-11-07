using Microsoft.AspNetCore.Mvc;
using HotelProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private static List<Order> orderList = new List<Order>();
        private static int orderNum=1;

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return orderList;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return orderList.Find(x=> x.OrderId==id);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public void Post([FromBody] Order o)
        {
            Order o1=new Order { OrderId=orderNum++,CustId=o.CustId,RoomId=o.RoomId,Start=o.Start,End=o.End,Payment=200};
            orderList.Add(o1);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Order o)
        {
            Order o1=orderList.Find(x=>x.OrderId==id);
            o1.RoomId=o.RoomId;
            o1.Start=o.Start;
            o1.End=o.End;

        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            Order o1 = orderList.Find(x => x.OrderId == id);
            orderList.Remove(o1);
        }
    }
}
