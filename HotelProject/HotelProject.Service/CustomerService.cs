using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.Core.Repositories;

namespace HotelProject.Service
{
    public class CustomerService : ICusromerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public void Delete(string id)
        {
            _customerRepository.Delete(id);
        }

        public IEnumerable<Customer> Get()
        {
            return _customerRepository.Get();
        }

        public Customer GetById(string id)
        {
            return _customerRepository.GetById(id);
        }

        public void Post(Customer c)
        {
            _customerRepository.Post(c);
        }

        public void Put(string id, Customer c)
        {
            _customerRepository.Put(id, c);
        }
    }
}
