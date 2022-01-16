using OOP.Abstraction;
using OOP.Encapsulation;
using OOP.Inheritance;
using OOP.Polymorphism;
using System;
using System.Collections.Generic;

namespace OOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Abstraction: Define a class by abstraction, which can contain attributes and methods.
            Customer customer;

            // 2. Encapsulation: Hide or protect internal implementation details, and can set attributes or methods through the access level(public, protected, private).
            var car = new Car();
            car.Drive(); // Hide or protect internal implementation details.
            //car.EngineOn(); // It is inaccesible due to its access level is protected.
            //car.GasPedal(); // It is inaccesible due to its access level is private.
            Console.WriteLine("--");

            // 3. Inheritance
            var bc = new BaseClass();
            bc.SayHi(); // Output: Hi Robot
            var bc2 = new BaseClass("Nick");
            bc2.SayHi(); // Output: Hi Nick
            var dc = new DerivedClass();
            // Output: Output: Hi Daniel
            // Output: Output: Hello Andy
            Console.WriteLine("--");

            // 4. Polymorphism
            // #1: A Square, Triangle can all be used whereever a Shape is expected.
            // No cast is required because an implicit conversion exists from a derived class to its base class.
            var shapes = new List<Shape>
            {
                new Square(),
                new Triangle(),
            };

            // #2: The virtual method Draw is invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            /* Output:
                Drawing a square
                Performing base class drawing tasks
                Drawing a triangle
                Performing base class drawing tasks
            */
        }
    }
}
