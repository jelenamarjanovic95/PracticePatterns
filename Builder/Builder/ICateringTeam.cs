using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface ICateringTeam
    {
        void CreateStarter();
        void CreateMainCourse();
        void CreateDessert();
        
        Menu GetMenu();
    }
}
