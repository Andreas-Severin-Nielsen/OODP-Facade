using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OODP_Facade.Sub
{
    class Facade : IFacade
    {
        private Class1 object1;
        private Class2 object2;
        private Class3 object3;

        public Facade(Class1 object1, Class2 object2, Class3 object3)
        {
            this.object1 = object1 ?? throw new ArgumentNullException(nameof(object1));
            this.object2 = object2 ?? throw new ArgumentNullException(nameof(object2));
            this.object3 = object3 ?? throw new ArgumentNullException(nameof(object3));
        }

        public string GetSystemClassNames()
        {
            return object1.StateName() + " + " + object2.Name + " + " + object3.GenerateName();
        }
    }
}
