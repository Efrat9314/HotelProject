using Microsoft.AspNetCore.Mvc;
using HotelProject.Core.Entities;
using HotelProject.Core.Repositories;
using HotelProject.API.Models;
using AutoMapper;
using HotelProject.Core.DTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProject.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService orderService,IMapper mapper)
        {
            _orderService = orderService;
            _mapper = mapper;
        }

        // GET: api/<OrdersController>
        [HttpGet]
        public IEnumerable<Order> Get()
        {
            return _orderService.Get();
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public ActionResult<Order> Get(int id)
        {
            return _orderService.GetById(id);    
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post([FromBody] OrderPostModel o)
        {
            Order order = new Order { CustomerId = o.CustId, RoomIdList = o.RoomIdList, NumDaysList = o.NumDaysList };
            _orderService.Post(order);
            return Ok(_mapper.Map<OrderDto>(order));
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] OrderPostModel o)
        {
            Order order = new Order { CustomerId = o.CustId, RoomIdList = o.RoomIdList, NumDaysList = o.NumDaysList };
            _orderService.Put(id,order);
            return Ok();
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           _orderService.Delete(id);
            return BadRequest();
        }
        
    }
}
