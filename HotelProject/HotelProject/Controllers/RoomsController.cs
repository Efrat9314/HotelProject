using Microsoft.AspNetCore.Mvc;
using HotelProject.Core;
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
    public class RoomsController : ControllerBase
    {
        private readonly IRoomService _roomService;
        private readonly IMapper _mapper;

        public RoomsController(IRoomService roomService,IMapper mapper)
        {
            _roomService = roomService;
            _mapper = mapper;
        }

       
        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return _roomService.Get();
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public ActionResult<Room> Get(int id)
        {
            return _roomService.GetById(id);
        }

        // POST api/<RoomsController>
        [HttpPost]
        public ActionResult Post([FromBody] RoomPostModel r)
        {
            Room room = new Room { Floor=r.Floor,Price=r.Price,NumOfBeds=r.NumOfBeds};
           _roomService.Post(room);
            return Ok(_mapper.Map<RoomDto>(room));
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] RoomPostModel r)
        {
            Room room = new Room { Floor = r.Floor, Price = r.Price, NumOfBeds = r.NumOfBeds };
            _roomService.Put(id, room);  
            return Ok();
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            _roomService.Delete(id);
            return Ok();    
        }
        //private int RoomNum(int floor)
        //{
        //    return _roomService.RoomNum(floor);
        //}
    }
}
