using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Factory
{
    public class ConcreteCreator1 : Creator
    {
        public override IProduct FactoryMeethod()
        {
            return new ConcreteProduct1();
        }
    }
}
