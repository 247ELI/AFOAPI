using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFOAPI.Services
{
    public class OddOrEvenService
    {
        public string CheckOddOrEven(int number)
        {
            return number % 2 == 0 ? "Even" : "Odd";
        }

    }
}
