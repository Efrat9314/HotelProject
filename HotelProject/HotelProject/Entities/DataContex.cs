namespace HotelProject.Entities
{
    public class DataContex
    {
        public List<Customer> customerList { get; set; }
        public List<Room> roomList { get; set; }
        public List<Order> orderList { get; set; }
        public int [] roomNumber { get; set; }
        public int orderNum { get; set; }

        public DataContex()
        {
            customerList = new List<Customer>();
            roomList = new List<Room>();
            orderList = new List<Order>();
            roomNumber = new int[8];
            orderNum = 1;
        }
    }
}
