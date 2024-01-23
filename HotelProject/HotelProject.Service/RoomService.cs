using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.Core;
using HotelProject.Core.Entities;
using HotelProject.Core.Repositories;

namespace HotelProject.Service
{
    public class RoomService : IRoomService
    {
        private readonly IRoomRepository _roomRepository;

        public RoomService(IRoomRepository roomRepository)
        {
            _roomRepository = roomRepository;
        }
        public void Delete(int id)
        {
            _roomRepository.Delete(id);
        }

        public IEnumerable<Room> Get()
        {
            return _roomRepository.Get();
        }

        public Room GetById(int id)
        {
            return _roomRepository.GetById(id);
        }

        public void Post(Room r)
        {
            _roomRepository.Post(r);
        }

        public void Put(int id, Room r)
        {
            _roomRepository.Put(id, r);  
        }

        public int RoomNum(int floor)
        {
            return _roomRepository.RoomNum(floor);
        }
    }
}
