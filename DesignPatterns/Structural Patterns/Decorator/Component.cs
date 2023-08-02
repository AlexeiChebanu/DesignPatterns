using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Decorator;

// Базовый интерфейс Компонента определяет поведение, которое изменяется
// декораторами.
public abstract class Component
{
    public abstract string Operation();
}

// Конкретные Компоненты предоставляют реализации поведения по умолчанию.
// Может быть несколько вариаций этих классов.
class ConcreteComponent : Component
{
    public override string Operation()
    {
        return "ConcreteComponent";
    }
}