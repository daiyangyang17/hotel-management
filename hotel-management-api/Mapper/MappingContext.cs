using AutoMapper;
using hotel_management_api.Dto;
using hotel_management_api.Models;
using hotel_management_api.Request;

namespace hotel_management_api.Mapper
{
    public class MappingContext : Profile
    {
        public MappingContext()
        {
            // user request
            CreateMap<UserRegisterRequest, User>();
            CreateMap<UserStoreRequest, User>();

            // Hotel room
            CreateMap<HotelRoomStoreRequest, HotelRoom>();
        }
    }
}
