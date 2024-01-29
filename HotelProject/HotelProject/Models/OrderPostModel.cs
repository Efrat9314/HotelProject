namespace HotelProject.API.Models
{
    public class OrderPostModel
    {
        public string CustId { get; set; }
        public List<int> NumDaysList { get; set; }
        public List<int> RoomIdList { get; set; }
    }
}
