using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class CateringTeamItaliano : ICateringTeam
    {
        private Menu menu;

        public CateringTeamItaliano()
        {
            menu = new Menu();
        }


        public void CreateStarter()
        {
            menu.Starter = new ShrimpStarter();
        }

        public void CreateMainCourse()
        {
            menu.MainCourse = new PastaMainCourse();
        }

        public void CreateDessert()
        {
            menu.Dessert = new TiramisuDessert();
        }
        

        public Menu GetMenu()
        {
            return menu;
        }
    }
}
