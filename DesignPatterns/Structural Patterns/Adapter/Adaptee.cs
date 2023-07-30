using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural_Patterns.Adapter;

// Адаптируемый класс содержит некоторое полезное поведение, но его
 // интерфейс несовместим  с существующим клиентским кодом. Адаптируемый
 // класс нуждается в некоторой доработке,  прежде чем клиентский код сможет
 // его использовать.
class Adaptee
{
    public string GetSpecificRequest()
    {
        return "Specific request.";
    }
}
