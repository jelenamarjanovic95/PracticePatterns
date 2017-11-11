using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private IKithenFactory _cateringTeamFactory;

        public Client(IKithenFactory ct)
        {
            _cateringTeamFactory = ct;
        }

        public string KreirajMeni()
        {
            IStarter starter = _cateringTeamFactory.GetStarter();
            IMainCourse mainCourse = _cateringTeamFactory.GetMainCourse();
            IDessert dessert = _cateringTeamFactory.GetDessert();

            return "MENU\n______________________________________\n" + starter.DishInfo +
                "\n" + mainCourse.DishInfo + "\n" + dessert.DishInfo + "\n\n";
        }
    }
}
