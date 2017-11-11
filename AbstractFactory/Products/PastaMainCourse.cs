using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class PastaMainCourse : IMainCourse
    {
        private string _info;

        public PastaMainCourse()
        {
            _info = "Main course: Pasta with chicken and mushrooms, made in cream sauce";
        }

        public string DishInfo => _info;
    }
}
