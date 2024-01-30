
using HotelProject.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace HotelProject.Data
{
    public class DataContext:DbContext
    {
        public DbSet<Customer> customerList { get; set; }
        public DbSet<Room> roomList { get; set; }
        public DbSet<Order> orderList { get; set; }
        public int[] roomNumber { get; set; }
        public int orderNum { get; set; }
         protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=EfratYanayHotel");
        }
    }
}
