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
    public class AddingTwoNumberController : ControllerBase
    {
        private readonly AddingTwoNumbersService _AddingTwoNumbersService;
        public AddingTwoNumberController(AddingTwoNumbersService addingTwoNumbersService)
        {
            _AddingTwoNumbersService = addingTwoNumbersService;
        }

        [HttpPost]
        [Route("AddingTwoNumbers/{FirstNumber},{SecondNumber}")]
        public string PostAddingTwoNumbers(int FirstNumber, int SecondNumber){

        return _AddingTwoNumbersService.AddingTwoNumbersMethod(FirstNumber, SecondNumber);
        }
    }
}