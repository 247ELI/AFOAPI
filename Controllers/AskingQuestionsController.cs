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
    public class AskQuestionsController : ControllerBase
    {
        private readonly AskQuestionsService _service;
        public AskQuestionsController(AskQuestionsService service)
        {
            _service = service;
        }

        [HttpGet("Ask/{name}/{wakeUpTime}")]
        public string Ask(string name, string wakeUpTime)
        {
            return _service.AskQuestion(name, wakeUpTime);
        }
    }
}