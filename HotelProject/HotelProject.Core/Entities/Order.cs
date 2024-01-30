namespace HotelProject.Core.Entities
{
    public class Order:BaseModel
    {
        public int Id { get; set; }
        public List<int> RoomIdList { get; set; }
        public string CustId { get; set; }
        public DateTime Start { get; set; }
        public List<int> NumDaysList { get; set; }
        public int Payment { get; set; }


        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
        public List<Room> RoomsList { get; set; }
    }
}
