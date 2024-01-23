using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Repositories
{
    public interface IOrderRepository
    {
        IEnumerable<Order> Get();
         Order GetById(int id);
        void Post( Order o);
        void Put(int id, Order o);
        void Delete(int id);
    }
}
