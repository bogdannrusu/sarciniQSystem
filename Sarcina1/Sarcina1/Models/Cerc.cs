using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sarcina1.Interfaces;

namespace Sarcina1.Models
{
    // Reprezintă un cerc ca figură geometrică.
    public class Cerc : IFiguriGeometrice
    {
        // Aici declar valorare pentru Raza cercului
        public double Radius { get; }

        // Aici am creat un constructor pentru inițializarea unui cerc cu o rază specificată.
        public Cerc(double radius)
        {
            if (radius <= 0)
                throw new ArgumentException("Raza trebuie să fie mai mare decât 0.");

            Radius = radius;
        }

        // Aici calculez aria cercului si returnez aria cercului, adica rezultatul
        public double CalculateArea() => Math.PI * Radius * Radius;

        // aici initializez numele figurii geometrice, in cazul dat este cerc
        public string Name => "Cerc";
    }
}
