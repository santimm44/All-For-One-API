using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.services
{
    public class OddOrEvenService
    {
        public string OddOrEvenMethod(string userNumber)
        {
            int number;
            bool userValidation = int.TryParse(userNumber, out number);
            
            if (!userValidation)
            {
                return "Invalid entry. Try again";
            }

            int moduoloUserNum = number % 2;
            
            if (moduoloUserNum == 0) return "Wow, you entered an even number!\n";
            else return "Wow, you entered an odd number!\n";
        }
    }
}