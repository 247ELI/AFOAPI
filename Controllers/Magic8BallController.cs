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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _service;

        public Magic8BallController(Magic8BallService service)
        {
            _service = service;
        }

        [HttpGet("{question}")]
        public string Ask(string question)
        {
            return _service.Ask(question);
        }
    }
}