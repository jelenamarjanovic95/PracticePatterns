using AbstractFactory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class CateringTeamTradition : ICateringTeam
    {
        public override void CreateMenu()
        {
            _menu = new Menu(new ProjaraStarter(), new Gulas(), new PrincessDonutsDessert());
        }
    }
}
