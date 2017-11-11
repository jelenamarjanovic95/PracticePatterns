using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class TiramisuDessert:IDessert
    {
        private string _info;

        public TiramisuDessert()
        {
            _info = "Dessert: Tiramisu";
        }

        public string DishInfo => _info;
    }
}
