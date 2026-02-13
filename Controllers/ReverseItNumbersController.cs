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
    public class ReverseItNumbersController : ControllerBase
    {
        private readonly ReverseItNumbersService _service;

        public ReverseItNumbersController(ReverseItNumbersService service)
        {
            _service = service;
        }

        [HttpGet("Reverse/{input}")]
        public string Reverse(string input)
        {
            return _service.ReverseNumbers(input);
        }
    }
}