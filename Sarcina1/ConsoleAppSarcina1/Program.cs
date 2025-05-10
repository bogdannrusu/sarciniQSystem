using Sarcina1.Interfaces;
using Sarcina1.Utilities;
using Sarcina1.Models;
using System;

// Creăm un cerc folosind ShapeFactory
var circle = ShapeFactory.CreateCircle(5);

// Creăm un triunghi folosind ShapeFactory
var triangle = ShapeFactory.CreateTriangle(3, 4, 5);

// Calculăm și afișăm aria cercului
Console.WriteLine($"Aria cercului: {circle.CalculateArea()}");

// Calculăm și afișăm aria triunghiului
Console.WriteLine($"Aria triunghiului: {triangle.CalculateArea()}");

// Verificăm dacă triunghiul este dreptunghic
if (triangle is Triunghi t)
{
    Console.WriteLine($"Este triunghiul dreptunghic? {t.IsRightAngled()}");
}
