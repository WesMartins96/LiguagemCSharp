using DesafioResolvido_POO_Classes_Abstratas.Entities.Enums;
using System;

namespace DesafioResolvido_POO_Classes_Abstratas.Entities
{
    class Circle : Shape
    {
        public double Radius { get; set; }


        public Circle(double radius, Color color) : base(color)
        {
            Radius = radius;
        }


        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}
