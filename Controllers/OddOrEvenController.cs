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
    public class OddOrEvenController : ControllerBase
    {
        private readonly OddOrEvenService _OddOrEvenService;
        public OddOrEvenController (OddOrEvenService oddOrEvenService)
        {
            _OddOrEvenService = oddOrEvenService;
        }

        [HttpPost]
        [Route("OddOrEven/{number}")]
        public string OddOrEven(string number)
        {
            return _OddOrEvenService.OddOrEvenMethod(number);
        }
    }
}