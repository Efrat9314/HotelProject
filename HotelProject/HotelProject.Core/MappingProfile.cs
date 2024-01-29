using AutoMapper;
using HotelProject.Core.DTOs;
using HotelProject.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Core
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Customer,CustomerDto>().ReverseMap();
            CreateMap<Order,OrderDto>().ReverseMap();
            CreateMap<Room,RoomDto>().ReverseMap();
        }
    }
}
