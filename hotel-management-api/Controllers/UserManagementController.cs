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
    public class UserManagementController : BaseApiController<UserManagementController>
    {
        private readonly UserService _userService;
        public UserManagementController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _userService = new UserService(apiConfig, databaseContext, mapper);
        }

        /// <summary>
        /// Search user
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Authorize(Roles = "Manager")]
        [Route("Get")]
        public MessageData Get(int limit, int page, string? name)
        {
            try
            {
                var res = _userService.GetUsers(limit, page, name);
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
        public MessageData Store(UserStoreRequest userStoreRequest)
        {
            try
            {
                var res = _userService.Store(userStoreRequest);
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
        public MessageData Update(int id, UserStoreRequest userStoreRequest)
        {
            try
            {
                var res = _userService.Update(id, userStoreRequest);
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
                var res = _userService.Delete(id);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
