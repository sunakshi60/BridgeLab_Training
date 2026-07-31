using System;

namespace Level1
{
    class Circle
    {
        double radius;

        public Circle() : this(1)
        {
        }

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void Display()
        {
            double area = 3.14 * radius * radius;
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + area);
        }
    }
}