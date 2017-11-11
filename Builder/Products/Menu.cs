using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Menu
    {
        IStarter _starter;
        IMainCourse _mainCourse;
        IDessert _dessert;

        //public Menu(IStarter s, IMainCourse mc, IDessert d)
        //{
        //    _starter = s;
        //    _mainCourse = mc;
        //    _dessert = d;
        //}

        public IDessert Dessert
        {
            get => _dessert;
            set
            {
                _dessert = value;
            }
        }

        public IMainCourse MainCourse
        {
            get => _mainCourse;
            set
            {
                _mainCourse = value;
            }
        }

        public IStarter Starter
        {
            get => _starter;
            set
            {
                _starter = value;
            }
        }

        public string GetMenuInfo()
        {
            return "MENU\n______________________________________\n" + _starter.GetStarter() +
                "\n" + _mainCourse.GetMainCourse() + "\n" + _dessert.GetDessert() + "\n\n";
        }

    }
}
