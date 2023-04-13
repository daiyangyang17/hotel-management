using AutoMapper;
using hotel_management_api.Common;
using hotel_management_api.Database;
using hotel_management_api.Models;
using hotel_management_api.Request;
using hotel_management_api.Respositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace hotel_management_api.Repositories
{
    public class HotelRoomRepository : BaseRespository<HotelRoom>
    {
        private IMapper _mapper;
        public HotelRoomRepository(ApiOption apiConfig, DatabaseContext databaseContext, IMapper mapper) : base(apiConfig, databaseContext)
        {
            this._mapper = mapper;
        }
    }
}
