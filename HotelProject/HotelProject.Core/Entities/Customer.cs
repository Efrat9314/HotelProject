namespace HotelProject.Core.Entities
{
    public class Customer:BaseModel
    {
        public string Id { get; set; }
        public string CustomerId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Adress { get; set; }

        public List<Order> OrdersList { get; set; }

    }
}
