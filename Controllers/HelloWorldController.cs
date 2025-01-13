using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using All_For_One_API.services;
using Microsoft.AspNetCore.Mvc;

namespace All_For_One_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        private readonly HelloWorldService _HelloWorldService;
        public HelloWorldController (HelloWorldService helloWorldService)
        {
            _HelloWorldService = helloWorldService;
        }

        [HttpPost]
        [Route("HelloWorld/{name}")]
        public string PostHelloWorld(string? name)
        {
            return _HelloWorldService.HelloWorldMethod(name);
        }
    }
}