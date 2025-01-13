using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.services
{
    public class AskingQuestionsService
    {
        public string GoodMorningMessage( int time, string name)
        {
            int realNumber;
            bool isNumber = int.TryParse(name, out realNumber);
            if (isNumber == true)
            {
                return $"Sorry, but you enter a number \"{realNumber}\" as a name";
            }
            return $"Hello {name}. You woke up at {time} o'clock today.";
        }
    }
}