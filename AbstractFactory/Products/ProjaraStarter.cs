using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ProjaraStarter : IStarter
    {
        private string _info;

        public ProjaraStarter()
        {
            _info = "Starter: Warm projarica - a bread-like dish made of corn flour filled with cheese";
        }

        public string DishInfo => _info;
    }
}
