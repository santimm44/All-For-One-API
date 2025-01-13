using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.services
{
    public class ReverseItAlphanumericService
    {
        public string ReverseItAlphanumericMethod(string userString){
            int arraySize = userString.Length;
            char[] reverseString = new char[arraySize];

            int j = 0;
            for (int i = arraySize-1; i >= 0; i--){
                reverseString[j] = userString[i];
                j++;
            }
             
            string reverseStringValue = string.Join("", reverseString);
            return $"You had entered {userString} which is {reverseStringValue} when reversed";

        }
    }
}