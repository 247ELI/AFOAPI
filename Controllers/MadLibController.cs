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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibService _service;
        public MadLibController(MadLibService service)
        {
            _service = service;
        }
        [HttpGet("Create/{color}/{noun}/{name}/{adjective}")]
        public string Create(string color, string noun, string name, string adjective)
        {
            return _service.MadlibResponses( color, noun, name, adjective);
        }
    }
}