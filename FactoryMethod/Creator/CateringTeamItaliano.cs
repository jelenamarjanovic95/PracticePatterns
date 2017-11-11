using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CateringTeamItaliano : ICateringTeam
    {
        
        public override void CreateMenu()
        {
            _menu = new Menu(new ShrimpStarter(), new PastaMainCourse(), new TiramisuDessert());

        }
        
    }
}
