namespace HotelProject.Core.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public List<int> RoomIdList { get; set; }
        public string CustId { get; set; }
        public DateTime Start { get; set; }
        public int numDays { get; set; }
        public int Payment { get; set; }


        public List<Room> RoomsList { get; set; }
        public string CustomerId { get; set; }
    }
}
