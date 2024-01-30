using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Repositories
{
    public interface IRoomService
    {
        IEnumerable<Room> Get();
        Room GetById(int id);
        void Post(Room r);
        void Put(int id, Room r);
        void Delete(int id);
        //int RoomNum(int floor);
    }
}
