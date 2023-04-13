using AutoMapper;
using AutoMapper.Configuration;
using hotel_management_api.Common;
using hotel_management_api.Controllers;
using hotel_management_api.Database;
using hotel_management_api.Dto;
using hotel_management_api.Request;
using hotel_management_api.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace hotel_management_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelRoomManagementController : BaseApiController<HotelRoomManagementController>
    {
        private readonly HotelRoomService _hotelRoomService;
        public HotelRoomManagementController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _hotelRoomService = new HotelRoomService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Search user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Manager")]
        [Route("Get")]
        public MessageData Get(int limit, int page)
        {
            try
            {
                var res = _hotelRoomService.GetHotelRooms(limit, page);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Manager")]
        [Route("Store")]
        public MessageData Store(HotelRoomStoreRequest hotelRoomStoreRequest)
        {
            try
            {
                var res = _hotelRoomService.Store(hotelRoomStoreRequest);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpPut]
        [Authorize(Roles = "Manager")]
        [Route("Update")]
        public MessageData Update(int id, HotelRoomStoreRequest hotelRoomStoreRequest)
        {
            try
            {
                var res = _hotelRoomService.Update(id, hotelRoomStoreRequest);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }

        /// <summary>
        /// Get achievement list of user
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        [Authorize(Roles = "Manager")]
        [Route("Delete")]
        public MessageData Delete(int id)
        {
            try
            {
                var res = _hotelRoomService.Delete(id);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
