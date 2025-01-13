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
    public class MadlibController : ControllerBase
    {
        private readonly MadlibService _MadlibService;
        public MadlibController (MadlibService madlibService)
        {
            _MadlibService = madlibService;
        }

        [HttpPost]
        [Route("MadLib/{monster},{monsterAdjec},{noun1},{noun2},{object1},{object2},{location},{location2},{userName},{userNameAdjec}")]
        public string MadLibPost(string monster, string monsterAdjec, string noun1, string noun2, string object1, string object2, string location, string location2, string userName, string userNameAdjec)
        {
            return _MadlibService.MadlibMethod(monster, monsterAdjec, noun1, noun2, object1, object2, location, location2,userName, userNameAdjec);
        }
    }
}