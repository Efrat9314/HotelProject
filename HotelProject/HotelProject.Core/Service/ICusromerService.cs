using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.Repositories
{
    public interface ICusromerService
    {
        IEnumerable<Customer> Get();
        Customer GetById(string id);
        void Post(Customer c);
        void Put(string id, Customer c);
        void Delete(string id);
    }
}
