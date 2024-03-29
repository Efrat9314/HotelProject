﻿using HotelProject.Core.Entities;
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
             Order o1 = new Order { CustId = o.CustId, RoomIdList = o.RoomIdList, Start = DateTime.Now, NumDaysList = o.NumDaysList, Payment = TotalPrice(o) };
            _context.orderList.Add(o1);
            _context.SaveChanges();

        }

        public void Put(int id, Order o)
        {
            Order o1 = _context.orderList.Find(id);
            o1.RoomIdList = o.RoomIdList;
            o1.Start = o.Start;
            o1.NumDaysList = o.NumDaysList;
            _context.SaveChanges();

        }
        public void Delete(int id)
        {
            Order o1 = _context.orderList.Find(id);
            _context.orderList.Remove(o1);
            _context.SaveChanges();

        }
        public int TotalPrice(Order ord)
        {
            int total = 0;
            Room r;
            for (int i = 0; i < ord.RoomIdList.Count; i++)
            {
                r = _context.roomList.Find(ord.RoomIdList[i]);
                total += r.Price * ord.NumDaysList[i];
            }
            return total;
        }
    }
}
