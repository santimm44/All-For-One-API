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
    public class ReverseItNumbersOnlyController : ControllerBase
    {
        private readonly ReverseItNumbersOnlyService _ReverseItNumbersOnlyService;
        public ReverseItNumbersOnlyController (ReverseItNumbersOnlyService reverseItNumbersOnlyService)
        {
            _ReverseItNumbersOnlyService = reverseItNumbersOnlyService;
        }
            [HttpPost]
        [Route("ReverseNumbers/{number}")]
        public string ReverseNumber(string number)
        {
            return _ReverseItNumbersOnlyService.ReverseItNumbersOnlyMethod(number);
        }
    }
}