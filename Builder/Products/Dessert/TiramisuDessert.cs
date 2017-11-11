using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class TiramisuDessert : IDessert
    {
        public string GetDessert()
        {
            return "Dessert: Tiramisu";
        }
    }
}
