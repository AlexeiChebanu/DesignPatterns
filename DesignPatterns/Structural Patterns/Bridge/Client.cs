namespace DesignPatterns.Structural_Patterns.Bridge;

class Client
{
    // За исключением этапа инициализации, когда объект Абстракции
    // связывается с определённым объектом Реализации, клиентский код должен
    // зависеть только от класса Абстракции. Таким образом, клиентский код
    // может поддерживать любую комбинацию абстракции и реализации.
    public void ClientCode(Abstraction abstraction)
    {
        Console.Write(abstraction.Operation());
    }
}
