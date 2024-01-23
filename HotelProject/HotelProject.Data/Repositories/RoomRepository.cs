using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.Core;
using HotelProject.Core.Entities;
using HotelProject.Core.Repositories;

namespace HotelProject.Data.Repositories
{
    public class RoomRepository : IRoomRepository
    {
        private readonly DataContext _context;
        public RoomRepository(DataContext dataContex)
        {
            _context = dataContex;
        }

        public IEnumerable<Room> Get()
        {
            return _context.roomList;
        }

        public Room GetById(int id)
        {
            Room r = _context.roomList.Find(id);
            return r;
        }

        public void Post(Room r)
        {
            Room r1 = new Room { RoomId = RoomNum(r.Floor), Price = r.Price, NumOfBeds = r.NumOfBeds, Floor = r.Floor };
            _context.roomList.Add(r1);
            _context.SaveChanges();
        }

        public void Put(int id, Room r)
        {
            Room r1 = _context.roomList.Find(id);
            r1.NumOfBeds = r.NumOfBeds;
            r1.Floor = r.Floor;
            r1.Price = r.Price;
            _context.SaveChanges();
        }
        public void Delete(int id)
        {
            Room r1 = _context.roomList.Find(id);
            _context.roomList.Remove(r1);
            _context.SaveChanges();
        }

        public int RoomNum(int floor)
        {
            return floor * 100 + _context.roomNumber[floor]++;
        }
    }
}
