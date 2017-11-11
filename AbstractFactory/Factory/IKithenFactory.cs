using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IKithenFactory
    {
        IStarter GetStarter();
        IMainCourse GetMainCourse();
        IDessert GetDessert();
    }
}
