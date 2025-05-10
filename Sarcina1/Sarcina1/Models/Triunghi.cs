using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sarcina1.Interfaces;

namespace Sarcina1.Models
{
    // Reprezinta un triunghi ca figura geometrica
    public class Triunghi : IFiguriGeometrice
    {
        // Lungimea laturii A a triunghiului
        public double A { get; }

        // Lungimea laturii B a triunghiului
        public double B { get; }

        // Lungimea laturii C a triunghiului
        public double C { get; }

        // Constructor pentru initializarea unui triunghi cu laturile specificate
        public Triunghi(double a, double b, double c)
        {
            if (!IsValidTriangle(a, b, c))
                throw new ArgumentException("Laturile nu formează un triunghi valid.");

            A = a;
            B = b;
            C = c;
        }

        //Verific dacă laturile date formează un triunghi valid
        private bool IsValidTriangle(double a, double b, double c)
        {
            return a + b > c && a + c > b && b + c > a;
        }

        // Calculez aria triunghiului folosind formula lui Heron
        public double CalculateArea()
        {
            double s = (A + B + C) / 2;
            return Math.Sqrt(s * (s - A) * (s - B) * (s - C));
        }
        
        // Verific daca triunghiul este dreptunghic
        public bool IsRightAngled()
        {
            var sides = new[] { A, B, C }.OrderBy(x => x).ToArray();
            return Math.Abs(sides[0] * sides[0] + sides[1] * sides[1] - sides[2] * sides[2]) < 1e-6;
        }


        public string Name => "Triunghi";
    }
}
