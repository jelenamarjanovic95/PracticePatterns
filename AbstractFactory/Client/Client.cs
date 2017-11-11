using AbstractFactory.Products;
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
        private Menu menu;

        public Client(IKithenFactory ct)
        {
            _cateringTeamFactory = ct;
        }

        public string CreateMenu()
        {
            IStarter starter = _cateringTeamFactory.GetStarter();
            IMainCourse mainCourse = _cateringTeamFactory.GetMainCourse();
            IDessert dessert = _cateringTeamFactory.GetDessert();

            menu = new Menu(starter, mainCourse, dessert);
            return menu.GetMenu();
        }
    }
}
