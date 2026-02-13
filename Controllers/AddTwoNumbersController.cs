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
    public class AddTwoNumbersController : ControllerBase
    {
        private readonly AddTwoNumbersService _service;
        public AddTwoNumbersController(AddTwoNumbersService service)
        {
            _service = service;
        }
        [HttpGet("Add/{num1}/{num2}")]
        public int Add(int num1, int num2)
        {
            return _service.Add(num1, num2);
        }
    }
}