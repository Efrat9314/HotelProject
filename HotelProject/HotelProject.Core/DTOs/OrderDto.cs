using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.DTOs
{
    public class OrderDto
    {
        public int Id { get; set; }
        public List<int> RoomIdList { get; set; }
        public string CustId { get; set; }
        public List<int> NumDays { get; set; }
        public int Payment { get; set; }

    }
}
