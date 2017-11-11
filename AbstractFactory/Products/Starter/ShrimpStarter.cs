using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ShrimpStarter : IStarter
    {
        private string _info;

        public ShrimpStarter()
        {
            _info = "Starter: Shrimp covered in a beautiful almond sauce";
        }

        public string DishInfo => _info;
    }
}
