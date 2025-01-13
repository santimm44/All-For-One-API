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
    public class RestaurantPickerController : ControllerBase
    {
        private readonly RestaurantPickerService _RestaurantPickerService;

        public RestaurantPickerController (RestaurantPickerService restaurantPickerService)
        {
            _RestaurantPickerService = restaurantPickerService;
        }

        [HttpGet]
        [Route("RestaurantPicker/{PickMexicanItalianOrChinese}")]
        public string GetRestaurantPicker(string? PickMexicanItalianOrChinese)
        {
            return _RestaurantPickerService.RestaurantPickerMethod(PickMexicanItalianOrChinese);
        }
    }
}