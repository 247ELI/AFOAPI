using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFOAPI.Services
{
    public class GuessItService
    {
        private static readonly System.Random _rand = new System.Random();

        private static readonly int _secret = _rand.Next(1, 20);

        public string Guess(int guess)
        {
            if (guess < 1 || guess > 20)
            {
                return "Guess must be between 1 and 20.";
            }

            if (guess < _secret) return "Too low!";
            if (guess > _secret) return "Too high!";
            return "Correct!";
        }
    }
}