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
    public class Magic8BallController : ControllerBase
    {
        private readonly Magic8BallService _Magic8BallService;
        public Magic8BallController (Magic8BallService magic8BallService)
        {
            _Magic8BallService = magic8BallService;
        }

        [HttpGet]
        [Route("Magic8Ball/{question}")]
        public string GetMagic8Ball (string? question)
        {
            return _Magic8BallService.Magic8BallMethod(question);
        }
    }
}