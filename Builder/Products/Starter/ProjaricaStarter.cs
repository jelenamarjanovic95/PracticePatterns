using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ProjaricaStarter : IStarter
    {
        public string GetStarter()
        {
            return "Starter: Warm projarica - a bread-like dish made of corn flour filled with cheese";
        }
    }
}
