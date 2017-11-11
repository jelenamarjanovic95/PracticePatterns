using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public abstract class ICateringTeam
    {
        protected IMenu _menu;
        
        public abstract void CreateMenu();
        public string GetMenuInfo() => _menu.GetMenuInfo();
    }
}
