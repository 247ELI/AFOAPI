using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFOAPI.Services
{
    public class AskQuestionsService
    {
        public string AskQuestion(string name, string wakeUpTime)
        {
            return $"Good morning, {name}! You Woke up at {wakeUpTime}.";
        }
    }
}