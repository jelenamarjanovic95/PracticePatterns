using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class PastaMainCourse : IMainCourse
    {
        public string GetMainCourse()
        {
            return "Main course: Pasta with chicken and mushrooms, made in cream sauce";
        }
    }
}
