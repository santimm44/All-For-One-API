using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.services
{
    public class AddingTwoNumbersService
    {
        public string AddingTwoNumbersMethod(int FirstNumber, int SecondNumber)
        {
            
            int sum = FirstNumber + SecondNumber;

            return $"The sum of {FirstNumber} and {SecondNumber} is {sum}";
        }
    }
}