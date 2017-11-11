using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Client
    {
        Menu menu;
        ICateringTeam cateringTeam;

        public Client(ICateringTeam ct)
        {
            cateringTeam = ct;
        }

        public void Create()
        {
            cateringTeam.CreateStarter();
            cateringTeam.CreateMainCourse();
            cateringTeam.CreateDessert();

            menu = cateringTeam.GetMenu();
        }

        public string Menu { get => menu.GetMenuInfo(); }
    }
}
