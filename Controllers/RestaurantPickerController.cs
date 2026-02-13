using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AFOAPI.Services;
using Microsoft.AspNetCore.Mvc;

namespace AFOAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _service;

        public RestaurantPickerController(RestaurantPickerService service)
        {
            _service = service;
        }

        [HttpGet("Pick/{category}")]
        public string Pick(string category)
        {
            return _service.Pick(category);
        }
    }
}