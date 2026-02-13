using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace AFOAPI.Services
{
    public class ReverseItNumbersService
    {
        public string ReverseNumbers(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return "Error: input cannot be empty.";
            }

            // Validate: every character must be a digit
            foreach (char c in input)
            {
                if (!char.IsDigit(c))
                {
                    return "Error: numbers only please.";
                }
            }

            // Reverse the input
            char[] chars = input.ToCharArray();
            System.Array.Reverse(chars);
            return new string(chars);
        }
    }
}