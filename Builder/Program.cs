using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
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

            Console.WriteLine("Client no1:\n" + c1.Menu);
            Console.WriteLine("Client no2:\n" + c2.Menu);
        }
    }
}
