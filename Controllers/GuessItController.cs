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
    public class GuessItController : ControllerBase
    {
        private readonly GuessItService _service;

        public GuessItController(GuessItService service)
        {
            _service = service;
        }

        [HttpGet("{guess}")]
        public string Guess(int guess)
        {
            return _service.Guess(guess);
        }
    }
}