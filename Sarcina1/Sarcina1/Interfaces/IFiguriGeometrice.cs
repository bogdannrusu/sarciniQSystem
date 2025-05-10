using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sarcina1.Interfaces
{
    // Interfata pentru figurile geometrice
    //Definesc aici metodele si proprietatile pentru toate figurile geometrice
    public interface IFiguriGeometrice
    {
        // Declar metoda pentru calcularea ariei
        double CalculateArea();

        // Numele figurii geometrice
        string Name { get; }
    }
}
