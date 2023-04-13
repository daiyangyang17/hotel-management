namespace hotel_management_api.Models
{
    public class Booking : BaseModel
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int HotelRoomId { get; set; }
        public DateTime ReservationTime { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public DateTime CheckinTime { get; set; }
        public DateTime CheckoutTime { get; set; }
        public double TotalPrice { get; set; }

    }
}
