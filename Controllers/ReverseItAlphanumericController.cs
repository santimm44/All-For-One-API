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
    public class ReverseItAlphanumericController : ControllerBase
    {
        private readonly ReverseItAlphanumericService _ReverseItAlphanumericService;
        public ReverseItAlphanumericController (ReverseItAlphanumericService reverseItAlphanumericService)
        {
            _ReverseItAlphanumericService = reverseItAlphanumericService;
        }

        [HttpPost]
        [Route("ReverseIt/{userInput}")]
        public string ReverseIt(string userInput){
            return _ReverseItAlphanumericService.ReverseItAlphanumericMethod(userInput);
        }
    }
}