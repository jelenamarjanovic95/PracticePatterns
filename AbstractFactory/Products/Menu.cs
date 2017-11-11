using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Products
{
    public class Menu
    {
        private IStarter _starter;
        private IMainCourse _mainCourse;
        private IDessert _dessert;

        public Menu(IStarter s, IMainCourse mc, IDessert d)
        {
            _starter = s;
            _mainCourse = mc;
            _dessert = d;
        }

        public string GetMenu()
        {
            return "MENU\n______________________________________\n" + _starter.DishInfo +
                "\n" + _mainCourse.DishInfo + "\n" + _dessert.DishInfo + "\n\n";

        }
    }
}
