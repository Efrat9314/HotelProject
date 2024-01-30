using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core.DTOs
{
    public class RoomDto
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int NumOfBeds { get; set; }
        public int Floor { get; set; }
    }
}
