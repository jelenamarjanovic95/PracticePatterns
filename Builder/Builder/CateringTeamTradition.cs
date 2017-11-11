using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CateringTeamTradition : ICateringTeam
    {

        private Menu menu;

        public CateringTeamTradition()
        {
            menu = new Menu();
        }


        public void CreateStarter()
        {
            menu.Starter = new ProjaricaStarter();
        }

        public void CreateMainCourse()
        {
            menu.MainCourse = new GulasMainCourse();
        }

        public void CreateDessert()
        {
            menu.Dessert = new PrincessDonutsDessert();
        }

        public Menu GetMenu()
        {
            return menu;
        }
    }
}
