using System;

namespace OverView
{
    //working of abstraction how we can hide implementation details, showing only essential features to the user.
    abstract class Shape
    {
        public abstract double GetArea();     // no implementation here
        public void Display()
        {
            Console.WriteLine($"Area = {GetArea()}");
        }
    }
    class Circle: Shape
    {
        private double radius;
        public Circle(double r) { radius = r; }
        public override double GetArea() => Math.PI* radius*radius;
    }

    class Rectangle  : Shape
    {
        private double length,width;
        public Rectangle(double l, double w) { length = l; width = w; }
        public override double GetArea() => length*width;
    }

}