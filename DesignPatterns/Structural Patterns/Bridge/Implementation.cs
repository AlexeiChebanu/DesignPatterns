namespace DesignPatterns.Structural_Patterns.Bridge;

// Реализация устанавливает интерфейс для всех классов реализации. Он не
// должен соответствовать интерфейсу Абстракции. На практике оба интерфейса
// могут быть совершенно разными. Как правило, интерфейс Реализации
// предоставляет только примитивные операции, в то время как Абстракция
// определяет операции более высокого уровня, основанные на этих примитивах.
public interface IImplementation
{
    string OperationImplementation();
}

// Каждая Конкретная Реализация соответствует определённой платформе и
// реализует интерфейс Реализации с использованием API этой платформы.
class ConcreteImplementationA : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform A.\n";
    }
}

class ConcreteImplementationB : IImplementation
{
    public string OperationImplementation()
    {
        return "ConcreteImplementationA: The result in platform B.\n";
    }
}
