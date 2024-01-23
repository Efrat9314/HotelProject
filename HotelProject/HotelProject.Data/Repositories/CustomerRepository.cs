using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelProject.Core.Entities;
using HotelProject.Core.Repositories;

namespace HotelProject.Data.Repositories
{
    public class CustomerRepository: ICustomerRepository 
    {
        private readonly DataContext _context;

        public CustomerRepository(DataContext dataContex)
        {
            _context = dataContex;
        }

        
        public IEnumerable<Customer> Get()
        {
            return _context.customerList;
        }

        public Customer GetById(string id)
        {
            Customer c = _context.customerList.Find(id);
            return c;
        }

        public void Post(Customer c)
        {
            Customer c1 = new Customer { CustomerId = c.CustomerId, Name = c.Name, Email = c.Email, Phone = c.Phone, Adress = c.Adress };
            _context.customerList.Add(c1);
            _context.SaveChanges();
        }

        public void Put(string id, Customer c)
        {
            Customer c1 = _context.customerList.Find(id);
            c1.Name = c.Name;
            c1.Email = c.Email;
            c1.Phone = c.Phone;
            c1.Adress = c.Adress;
            _context.SaveChanges();

        }
        public void Delete(string id)
        {
            Customer c1 = _context.customerList.Find(id);
            _context.customerList.Remove(c1);
            _context.SaveChanges();
        }

    }
}
