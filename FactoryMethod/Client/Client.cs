using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Client
    {
        ICateringTeam cateringTeam;

        public Client(ICateringTeam ct)
        {
            cateringTeam = ct;
        }

        public void Create()
        {
            cateringTeam.CreateMenu();
        }

        //???
        public void ShowMenuInfo()
        {
            Console.WriteLine(cateringTeam.GetMenuInfo());
        }
    }
}
