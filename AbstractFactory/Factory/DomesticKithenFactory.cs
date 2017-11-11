using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class DomesticKithenFactory : IKithenFactory
    {
        public IDessert GetDessert()
        {
            return new PrincessDonutsDessert();
        }

        public IMainCourse GetMainCourse()
        {
            return new Gulas();
        }

        public IStarter GetStarter()
        {
            return new ProjaraStarter();
        }
    }
}
