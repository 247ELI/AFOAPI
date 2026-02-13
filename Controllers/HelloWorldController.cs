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
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldService _service;

    public HelloWorldController(HelloWorldService service)
    {
        _service = service;
    }

    [HttpGet("Hello")]
    public string Hello()
    {
        return _service.SayHello();
    }

    [HttpGet("Hello/{name}")]
    public string HelloName(string name)
    {
        return _service.SayHelloTo(name);
    }
    }
}