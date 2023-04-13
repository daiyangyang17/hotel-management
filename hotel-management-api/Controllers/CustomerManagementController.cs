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
    public class CustomerManagementController : BaseApiController<CustomerManagementController>
    {
        private readonly CustomerService _customerService;
        public CustomerManagementController(DatabaseContext databaseContext, IMapper mapper, ApiOption apiConfig)
        {
            _customerService = new CustomerService(apiConfig, databaseContext, mapper);
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
                var res = _customerService.GetCustomers(limit, page, name);
                return new MessageData { Data = res };
            }
            catch (Exception ex)
            {
                return new MessageData() { Code = "error", Des = ex.Message };
            }
        }
    }
}
