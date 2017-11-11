using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class Program
    {
        static void Main(string[] args)
        {
            ICateringTeam ct1 = new CateringTeamItaliano();
            ICateringTeam ct2 = new CateringTeamTradition();

            Client c1 = new Client(ct1);
            Client c2 = new Client(ct2);

            c1.Create();
            c2.Create();

            c1.ShowMenuInfo();
            c2.ShowMenuInfo();
        }
    }
}
