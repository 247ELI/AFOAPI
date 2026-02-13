using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AFOAPI.Services
{
    public class RestaurantPickerService
    {
        private static readonly string[] Asian =
        {
        "Panda Express", "Pei Wei", "PF Chang's", "Teriyaki Madness", "Pick Up Stix"
    };

        private static readonly string[] Italian =
        {
        "Olive Garden", "Carrabba's", "Maggiano's", "Buca di Beppo", "Fazoli's"
    };

        private static readonly string[] Coffee =
        {
        "Starbucks", "Dunkin'", "Peet's Coffee", "Dutch Bros", "Caribou Coffee"
    };

        public string Pick(string category)
        {
            string clean = category.ToLower();

            if (clean == "asian") return PickFrom(Asian);
            if (clean == "italian") return PickFrom(Italian);
            if (clean == "coffee") return PickFrom(Coffee);

            return "Error: choose a category: asian, italian, or coffee.";
        }



        private string PickFrom(string[] list)
        {
            System.Random rand = new System.Random();
            int index = rand.Next(0, list.Length);
            return list[index];
        }
    }
}