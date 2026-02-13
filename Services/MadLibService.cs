using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFOAPI.Services
{
    public class MadLibService
    {
        public string MadlibResponses(string name, string color, string noun, string adjective)
        {
            return $"{name} was minding their own business when a {adjective} {noun} painted {color} rolled past. No one ever explained it.";

        }
    }
}