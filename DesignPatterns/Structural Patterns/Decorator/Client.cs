using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Decorator;

public class ClientDecorator
{
    // Клиентский код работает со всеми объектами, используя интерфейс
    // Компонента. Таким образом, он остаётся независимым от конкретных
    // классов компонентов, с которыми работает.
    public void ClientCode(Component component)
    {
        Console.WriteLine("RESULT: " + component.Operation());
    }
}

/*class ProgramDecorator
{
    static void Main(string[] args)
    {
        ClientDecorator client = new ClientDecorator();

        var simple = new ConcreteComponent();
        Console.WriteLine("Client: I get a simple component:");
        client.ClientCode(simple);
        Console.WriteLine();

        // ...так и декорированные.
        //
        // Обратите внимание, что декораторы могут обёртывать не только
        // простые компоненты, но и другие декораторы.
        ConcreteDecoratorA decorator1 = new ConcreteDecoratorA(simple);
        ConcreteDecoratorB decorator2 = new ConcreteDecoratorB(decorator1);
        Console.WriteLine("Client: Now I've got a decorated component:");
        client.ClientCode(decorator2);
    }
}*/