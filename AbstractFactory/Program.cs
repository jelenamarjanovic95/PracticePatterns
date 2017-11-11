using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AbstractFactory
{
    public class Program
    {
        static void Main(string[] args)
        {
            IKithenFactory italianFactory = new ItalianKithenFactory();
            IKithenFactory domesticFactory = new DomesticKithenFactory();

            Client c1 = new Client(italianFactory);
            Client c2 = new Client(domesticFactory);

            Console.WriteLine("***First client*** \n\n" + c1.KreirajMeni());
            Console.WriteLine("***Second client*** \n\n" + c2.KreirajMeni());
        }
    }
}
