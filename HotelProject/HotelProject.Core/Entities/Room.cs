namespace HotelProject.Core.Entities
{
    public class Room:BaseModel
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int NumOfBeds { get; set; }
        public int Floor { get; set; }

        public List<Order> OrdersList { get; set; }
    }
}
