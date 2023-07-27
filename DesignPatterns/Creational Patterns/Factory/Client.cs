using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational_Patterns.Factory;

public class Client
{
    public void Main()
    {
        Console.WriteLine("App: Launched with ConcreteCr1");
        ClientCode(new ConcreteCreator1());

        Console.WriteLine("\n");

        Console.WriteLine("App: Launched with ConcreteCr2");
        ClientCode(new ConcreteCreator2());
    }

    public void ClientCode(Creator creator)
    {
        Console.WriteLine(creator.SomeOperation());
    }
}
