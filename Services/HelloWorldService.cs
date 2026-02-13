using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFOAPI.Services
{
    public class HelloWorldService
    {
        public string SayHello() => "Hello, World!";
        public string SayHelloTo(string name) => $"Hello, {name}!";
    }
}