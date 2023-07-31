namespace DesignPatterns.Structural_Patterns.Bridge;

// Абстракция устанавливает интерфейс для «управляющей» части двух иерархий
// классов. Она содержит ссылку на объект из иерархии Реализации и
// делегирует ему всю настоящую работу.
class Abstraction
{
    protected IImplementation _implementation;

    public Abstraction(IImplementation implementation)
    {
        this._implementation = implementation;
    }

    public virtual string Operation()
    {
        return "Abstract: Base operation with:\n" +
            _implementation.OperationImplementation();
    }
}

// Можно расширить Абстракцию без изменения классов Реализации.
class ExtendedAbstraction : Abstraction
{
    public ExtendedAbstraction(IImplementation implementation) : base(implementation)
    {
    }

    public override string Operation()
    {
        return "ExtendedAbstraction: Extended operation with:\n" +
            base._implementation.OperationImplementation();
    }
}

class ProgramBridge
{
    static void Main(string[] args)
    {
        Client client = new Client();

        Abstraction abstraction;
        // Клиентский код должен работать с любой предварительно
        // сконфигурированной комбинацией абстракции и реализации.
        abstraction = new Abstraction(new ConcreteImplementationA());
        client.ClientCode(abstraction);

        Console.WriteLine();

        abstraction = new ExtendedAbstraction(new ConcreteImplementationB());
        client.ClientCode(abstraction);
    }
}
