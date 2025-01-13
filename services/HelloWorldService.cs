using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace All_For_One_API.services
{
    public class HelloWorldService
    {
        public string HelloWorldMethod(string? name)
        {
            return $"Hello, {name}";
        }
    }
}