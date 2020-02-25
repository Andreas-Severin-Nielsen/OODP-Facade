using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Facade
{
    class Client
    {
        public void DoYourThing()
        {
            Sub.IFacade facade = new Sub.Factory().CreateClasses();
            Console.WriteLine("Classes made: " + facade.GetSystemClassNames());
        }
    }
}
