using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ShrimpStarter : IStarter
    {
        public string GetStarter()
        {
            return "Starter: Shrimp covered in a beautiful almond sauce";
        }
    }
}
