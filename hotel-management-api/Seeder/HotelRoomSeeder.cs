using Microsoft.EntityFrameworkCore;
using hotel_management_api.Models;
using hotel_management_api.Common;
using hotel_management_api.Common.Enum;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace hotel_management_api.Seeder
{
    class HotelRoomSeeder
    {
        private readonly ModelBuilder _modelBuilder;
        public HotelRoomSeeder(ModelBuilder modelBuilder)
        {
            _modelBuilder = modelBuilder;
        }

        /// <summary>
        /// Excute data
        /// </summary>
        public void SeedData()
        {
            _modelBuilder.Entity<HotelRoom>().HasData(
                new HotelRoom
                {
                    Id = 1,
                    NoRoom = "201",
                    Floor = 2,
                    RoomType = RoomTypeEnum.SingleRoom,
                    NumberBed = 1,
                    Area = 28,
                    Size = "7mx4m",
                    Price = 3000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                },
                new HotelRoom
                {
                    Id = 2,
                    NoRoom = "202",
                    Floor = 2,
                    RoomType = RoomTypeEnum.DoubleRoom,
                    NumberBed = 2,
                    Area = 40,
                    Size = "8mx5m",
                    Price = 5000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                },
                new HotelRoom
                {
                    Id = 3,
                    NoRoom = "203",
                    Floor = 2,
                    RoomType = RoomTypeEnum.VIPRoom,
                    NumberBed = 1,
                    Area = 35,
                    Size = "7mx5m",
                    Price = 3000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                },


                new HotelRoom
                {
                    Id = 4,
                    NoRoom = "301",
                    Floor = 3,
                    RoomType = RoomTypeEnum.SingleRoom,
                    NumberBed = 1,
                    Area = 28,
                    Size = "7mx4m",
                    Price = 3000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                },
                new HotelRoom
                {
                    Id = 5,
                    NoRoom = "302",
                    Floor = 3,
                    RoomType = RoomTypeEnum.DoubleRoom,
                    NumberBed = 2,
                    Area = 40,
                    Size = "8mx5m",
                    Price = 5000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                },
                new HotelRoom
                {
                    Id = 6,
                    NoRoom = "303",
                    Floor = 3,
                    RoomType = RoomTypeEnum.VIPRoom,
                    NumberBed = 1,
                    Area = 35,
                    Size = "7mx5m",
                    Price = 3000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                },

                new HotelRoom
                {
                    Id = 7,
                    NoRoom = "401",
                    Floor = 4,
                    RoomType = RoomTypeEnum.SingleRoom,
                    NumberBed = 1,
                    Area = 28,
                    Size = "7mx4m",
                    Price = 3000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                },
                new HotelRoom
                {
                    Id = 8,
                    NoRoom = "402",
                    Floor = 4,
                    RoomType = RoomTypeEnum.DoubleRoom,
                    NumberBed = 2,
                    Area = 40,
                    Size = "8mx5m",
                    Price = 5000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                },
                new HotelRoom
                {
                    Id = 9,
                    NoRoom = "403",
                    Floor = 4,
                    RoomType = RoomTypeEnum.VIPRoom,
                    NumberBed = 1,
                    Area = 35,
                    Size = "7mx5m",
                    Price = 3000000,
                    RoomStatus = RoomStatusEnum.VacantReady,
                    Option = "",
                    Image = "",
                    Description = ""
                });
        }
    }
}
