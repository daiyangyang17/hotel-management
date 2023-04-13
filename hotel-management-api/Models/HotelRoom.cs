using hotel_management_api.Common.Enum;

namespace hotel_management_api.Models
{
    public class HotelRoom : BaseModel
    {
        public int Id { get; set; }
        public string NoRoom { get; set; }
        public int Floor { get; set; }
        public RoomTypeEnum RoomType { get; set; }
        public int NumberBed { get; set; }
        public int Area { get; set; }
        public string Size { get; set; }
        public double Price { get; set; }
        public RoomStatusEnum RoomStatus { get; set; }
        public string Option { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
    }
}
