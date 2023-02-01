using System;
using System.Collections.Generic;

namespace OOP.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var shapes = new List<Shape>()
            {
                new Triangle(),
                new Oblong(),
                new Circle(),
                new Square()
            };

            // Polymorphism -> Ilgili nesneleri base sinif ile temsil edip bir metodu/porperty override ederek farkli davranmasi gibi dusunebiliriz.
            foreach (var shape in shapes)
            {
                shape.Draw();   // Ucunu de farkli sekilde cizdi. 
            }

            new Square().Calculate();
            Console.ReadLine();
        }

        private static void VirtualKeywords()
        {
            var _s1 = new Oblong();
            var _s2 = new Circle();

            _s1.X = 10;
            _s1.Y = 100;
            Console.WriteLine("{0},{1}", _s1.X, _s1.Y);
            _s1.Draw();

            _s2.X = 5;
            _s2.Y = 55;
            Console.WriteLine("{0},{1}", _s2.X, _s2.Y);
            _s2.Draw();

            new Triangle().Draw();
        }
    }
}
