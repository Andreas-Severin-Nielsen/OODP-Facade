using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Facade.Sub
{
    class Factory
    {
        public IFacade CreateClasses()
        {
            Class1 o1 = new Class1();
            Class2 o2 = new Class2();
            Class3 o3 = new Class3();
            IFacade facade = new Facade(o1, o2, o3);
            return facade;
        }
    }
}
