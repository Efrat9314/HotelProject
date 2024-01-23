using HotelProject.Core.Entities;
using HotelProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Data.Repositories
{
    public class OrderRepository:IOrderRepository
    {
        private readonly DataContext _context;

        public OrderRepository(DataContext dataContex)
        {
            _context = dataContex;
        }

        
        public IEnumerable<Order> Get()
        {
            return _context.orderList;
        }

        public Order GetById(int id)
        {
            Order o = _context.orderList.Find(id);
            return o;
        }

        public void Post(Order o)
        {
            //TODO מס' חדר-שדה חובה
            Room r = _context.roomList.Find(o.RoomIdList.First());
            Order o1 = new Order { OrderId = _context.orderNum++, CustId = o.CustId, RoomIdList = o.RoomIdList, Start = o.Start, numDays = o.numDays, Payment = o.numDays * r.Price };
            _context.orderList.Add(o1);
            _context.SaveChanges();

        }

        public void Put(int id, Order o)
        {
            Order o1 = _context.orderList.Find(id);
            o1.RoomIdList = o.RoomIdList;
            o1.Start = o.Start;
            o1.numDays = o.numDays;
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            Order o1 = _context.orderList.Find(id);
            _context.orderList.Remove(o1);
            _context.SaveChanges();

        }
    }
}
