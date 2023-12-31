﻿using Microsoft.AspNetCore.Mvc;
using HotelProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        DataContex contex;
        public OrdersController(DataContex contex)
        {
            this.contex = contex;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return contex.orderList;
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            Order o= contex.orderList.Find(x => x.OrderId == id);
            if (o == null)
                return NotFound();
            return o;
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post([FromBody] Order o)
        {
            Room r = contex.roomList.Find(x => x.RoomId == o.RoomId);
            if (r == null)
                return NotFound();
            Order o1 = new Order { OrderId = contex.orderNum++, CustId = o.CustId, RoomId = o.RoomId, Start = o.Start, numDays = o.numDays, Payment = o.numDays*r.Price};
            contex.orderList.Add(o1);
            return Ok();
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Order o)
        {
            Order o1 = contex.orderList.Find(x => x.OrderId == id);
            if(o1==null)
                NotFound();
            o1.RoomId = o.RoomId;
            o1.Start = o.Start;
            o1.numDays = o.numDays;
            return Ok();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Order o1 = contex.orderList.Find(x => x.OrderId == id);
            if(o1==null)
                return NotFound();
            contex.orderList.Remove(o1);
            return BadRequest();
        }
        
    }
}
