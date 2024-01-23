using HotelProject.Core.Entities;
using HotelProject.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public IEnumerable<Order> Get()
        {
            return _orderRepository.Get();
        }

        public Order GetById(int id)
        {
            return _orderRepository.GetById(id);
        }

        public void Post(Order o)
        {
            _orderRepository.Post(o);
        }

        public void Put(int id, Order o)
        {
            _orderRepository.Put(id, o);
        }
        public void Delete(int id)
        {
            _orderRepository.Delete(id);      
        }
    }
}
