using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFOAPI.Services
{
    public class Magic8BallService
    {
        private static readonly string[] responses = new[]
        {
           "Do it.",
            "Wait.",
            "Maybe later.",
            "Trust yourself.",
            "Let it go.",
            "Try again.",
            "Not today.",
            "Go outside.",
            "Think twice.",
            "Why not?",
            "Focus.",
            "Relax.",
            "Move on.",
            "Stay curious.",
            "Be patient.",
            "Change course.",
            "Keep going.",
            "Stop.",
            "Reset.",
            "Next step."

        };

        public string Ask(string question)
        {
            Random rand = new Random();
            int index = rand.Next(responses.Length);
            return responses[index];
        }
    }
}