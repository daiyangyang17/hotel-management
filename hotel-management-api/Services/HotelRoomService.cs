using AutoMapper;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using hotel_management_api.Common;
using hotel_management_api.Common.Enum;
using hotel_management_api.Database;
using hotel_management_api.Dto;
using hotel_management_api.Models;
using hotel_management_api.Repositories;
using hotel_management_api.Request;
using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;

namespace hotel_management_api.Services
{
    public class HotelRoomService
    {
        private readonly HotelRoomRepository _hotelRoomRepository;
        private readonly IMapper _mapper;
        public HotelRoomService(ApiOption apiOption, DatabaseContext databaseContext, IMapper mapper)
        {
            _hotelRoomRepository = new HotelRoomRepository(apiOption, databaseContext, mapper);
            _mapper = mapper;
        }

        /// <summary>
        /// Get hotel room
        /// </summary>
        /// <returns></returns>
        public object GetHotelRooms(int limit, int page)
        {
            try
            {
                var query = this._hotelRoomRepository.FindAll();
                //if (name != null)
                //{
                //    query = query.Where(row => row.Name.Contains(name));
                //}
                query.Skip((page - 1) * limit).Take(limit);
                var total = query.Count();
                int tmpByInt = total / limit;
                double tmpByDouble = (double)total / (double)limit;
                int totalPage = 1;
                if(tmpByDouble > (double)tmpByInt)
                {
                    totalPage = tmpByInt + 1;
                }
                else
                {
                    totalPage = tmpByInt;
                }
                query = query.Skip((page - 1) * limit).Take(limit);
                var amount = query.Count();
                return new
                {
                    data = query.ToList(),
                    Amount = amount,
                    PageSize = limit,
                    Total = total,
                    TotalPage = totalPage,
                };
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Create hotel room
        /// </summary>
        /// <param name="hotelRoomStoreRequest"></param>
        /// <returns></returns>
        public object Store(HotelRoomStoreRequest hotelRoomStoreRequest)
        {
            try
            {
                var hotelCheckList = _hotelRoomRepository.FindAll().Where(row => row.NoRoom == hotelRoomStoreRequest.NoRoom);
                if (hotelCheckList.Count() > 0)
                {
                    throw new Exception("No room already exist!");
                }
                var hotelRoom = _mapper.Map<HotelRoom>(hotelRoomStoreRequest);

                _hotelRoomRepository.Create(hotelRoom);
                _hotelRoomRepository.SaveChange();

                return hotelRoom;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Update hotel room
        /// </summary>
        /// <param name="id"></param>
        /// <param name="hotelRoomStoreRequest"></param>
        /// <returns></returns>
        public object Update(int id, HotelRoomStoreRequest hotelRoomStoreRequest)
        {
            try
            {
                var hotelRoom = _hotelRoomRepository.FindOrFail(id);
                if (hotelRoom == null)
                {
                    throw new Exception("Hotel room does not exit!");
                }
                var hotelRoomUpdate = _mapper.Map<HotelRoom>(hotelRoomStoreRequest);
                hotelRoomUpdate.Id = id;
                hotelRoomUpdate.CreatedDate = hotelRoom.CreatedDate;
                hotelRoomUpdate.UpdatedDate = DateTime.UtcNow;
                _hotelRoomRepository.UpdateByEntity(hotelRoomUpdate);
                _hotelRoomRepository.SaveChange();
                return hotelRoomUpdate;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        /// <summary>
        /// Delete hotel room
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public object Delete(int id)
        {
            try
            {
                var hotelRoom = _hotelRoomRepository.FindOrFail(id);
                if (hotelRoom == null)
                {
                    throw new Exception("Hotel room does not exit!");
                }

                _hotelRoomRepository.DeleteByEntity(hotelRoom);
                _hotelRoomRepository.SaveChange();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
