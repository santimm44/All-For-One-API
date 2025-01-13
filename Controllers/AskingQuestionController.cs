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
    public class AskingQuestionController : ControllerBase
    {
        private readonly AskingQuestionsService _AskingQuestionsService;
        public AskingQuestionController (AskingQuestionsService askingQuestionsService)
        {
            _AskingQuestionsService = askingQuestionsService;
        }

        [HttpPost]
        [Route("GoodMorning/{time},{name}")]
        public string CallGoodMorning(int time, string name)
        {
            return _AskingQuestionsService.GoodMorningMessage(time, name);
        }
    }
}