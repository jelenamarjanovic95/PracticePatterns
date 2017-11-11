using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Gulas : IMainCourse
    {
        private string _info;

        public Gulas()
        {
            _info = "Main course: Gulas with mushrooms";
        }

        public string DishInfo => _info;
    }
}
