using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class ItalianKithenFactory : IKithenFactory
    {
        public IDessert GetDessert()
        {
            return new TiramisuDessert();
        }

        public IMainCourse GetMainCourse()
        {
            return new PastaMainCourse();
        }

        public IStarter GetStarter()
        {
            return new ShrimpStarter();
        }
    }
}
