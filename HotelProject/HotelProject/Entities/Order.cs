namespace HotelProject.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int RoomId { get; set; }
        public string CustId { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public int Payment { get; set; }
    }
}
