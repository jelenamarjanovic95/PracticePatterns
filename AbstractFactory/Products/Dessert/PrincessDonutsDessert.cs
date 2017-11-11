using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PrincessDonutsDessert : IDessert
    {
        private string _info;

        public PrincessDonutsDessert()
        {
            _info = "Dessert: Princess Donuts, filled with vanilla cream";
        }

        public string DishInfo => _info;
    }
}
