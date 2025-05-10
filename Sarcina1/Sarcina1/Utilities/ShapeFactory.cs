using Sarcina1.Interfaces;
using Sarcina1.Models;

namespace Sarcina1.Utilities
{
    public static class ShapeFactory
    {
        // Clasă utilitară pentru a calcula aria oricărei forme geometrice.
        public static IFiguriGeometrice CreateCircle(double radius) => new Cerc(radius);

        public static IFiguriGeometrice CreateTriangle(double a, double b, double c) => new Triunghi(a, b, c);
    }
}
