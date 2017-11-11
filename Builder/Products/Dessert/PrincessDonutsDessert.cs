using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PrincessDonutsDessert : IDessert
    {
        public string GetDessert()
        {
            return "Dessert: Princess Donuts, filled with vanilla cream";
        }
    }
}
