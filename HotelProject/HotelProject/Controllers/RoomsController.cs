using Microsoft.AspNetCore.Mvc;
using HotelProject.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomsController : ControllerBase
    {
        DataContex contex;
        public RoomsController(DataContex contex)
        {
            this.contex = contex;
        }

        private int RoomNum(int floor)
        {
            return floor * 100 + contex.roomNumber[floor]++;
        }

        // GET: api/<RoomsController>
        [HttpGet]
        public IEnumerable<Room> Get()
        {
            return contex.roomList;
        }

        // GET api/<RoomsController>/5
        [HttpGet("{id}")]
        public ActionResult<Room> Get(int id)
        {
            Room r= contex.roomList.Find(x => x.RoomId == id);
            if(r==null)
                return NotFound();
            return r;
        }

        // POST api/<RoomsController>
        [HttpPost]
        public ActionResult Post([FromBody] Room r)
        {
            Room r1 = new Room { RoomId = RoomNum(r.Floor), Price = r.Price, NumOfBeds = r.NumOfBeds, Floor = r.Floor};
            if(r1==null)
                return NotFound();
            contex.roomList.Add(r1);
            return Ok();
        }

        // PUT api/<RoomsController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Room r)
        {
            Room r1 = contex.roomList.Find(x => x.RoomId == id);
            if(r1==null)
                return NotFound();
            r1.NumOfBeds = r.NumOfBeds;
            r1.Floor = r.Floor;
            r1.Price = r.Price;
            return Ok();
        }

        // DELETE api/<RoomsController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            Room r1 = contex.roomList.Find(x => x.RoomId == id);
            if(r1==null)
                NotFound();
            contex.roomList.Remove(r1);
            return Ok();    
        }
    }
}
