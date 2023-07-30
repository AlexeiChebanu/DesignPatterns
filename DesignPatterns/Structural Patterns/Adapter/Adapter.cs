namespace DesignPatterns.Structural_Patterns.Adapter;

public interface ITarget
{
    string GetRequest();
}

// Адаптер делает интерфейс Адаптируемого класса совместимым с целевым
// интерфейсом.
class Adapter : ITarget
{
    private readonly Adaptee _adaptee;

    public Adapter(Adaptee adaptee)
    {
        this._adaptee = adaptee;
    }

    public string GetRequest()
    {
        return $"This is '{this._adaptee.GetSpecificRequest()}'";
    }
}
