using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Flyweight;

public class Flyweight
{
    private Car _sharedState;

    public Flyweight(Car car)
    {
        this._sharedState = car;
    }

    public void Operation(Car uniqueState)
    {
        string s = JsonConvert.SerializeObject(this._sharedState);
        string u = JsonConvert.SerializeObject(uniqueState);
        Console.WriteLine($"Flyweight: Displaying shared {s} and unique {u} state.");
    }
}

/*class ProgramFlyweight
{
    static void Main(string[] args)
    {
        // Клиентский код обычно создает кучу предварительно заполненных
        // легковесов на этапе инициализации приложения.
        var factory = new FlyweightFactory(
            new Car { Company = "Chevrolet", Model = "Camaro2018", Color = "pink" },
            new Car { Company = "Mercedes Benz", Model = "C300", Color = "black" },
            new Car { Company = "Mercedes Benz", Model = "C500", Color = "red" },
            new Car { Company = "BMW", Model = "M5", Color = "red" },
            new Car { Company = "BMW", Model = "X6", Color = "white" }
        );
        factory.listFlyweights();

        addCarToPoliceDatabase(factory, new Car
        {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "M5",
            Color = "red"
        });

        addCarToPoliceDatabase(factory, new Car
        {
            Number = "CL234IR",
            Owner = "James Doe",
            Company = "BMW",
            Model = "X1",
            Color = "red"
        });

        factory.listFlyweights();
    }

    public static void addCarToPoliceDatabase(FlyweightFactory factory, Car car)
    {
        Console.WriteLine("\nClient: Adding a car to database.");

        var flyweight = factory.GetFlyweight(new Car
        {
            Color = car.Color,
            Model = car.Model,
            Company = car.Company
        });

        // Клиентский код либо сохраняет, либо вычисляет внешнее состояние и
        // передает его методам легковеса.
        flyweight.Operation(car);
    }
}
*/