using System;
using System.Collections.Generic;

namespace OOP.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var s1 = new Oblong(10, 20);  // parametreleri direkt base classin constructorinda geciyoruz.
            Console.WriteLine("{0},{1}", s1.X, s1.Y);

            var s2 = new Circle(5, 5);
            Console.WriteLine("{0},{1}", s2.X, s2.Y);   // output -> 0,0   cunku constructor'da base constructor'a parametre gondermedik.

            var s3 = new Square(45, 50);
            Console.WriteLine("{0},{1}", s3.X, s3.Y);   // Square'den base'e (Oblong'a) gidiyor. Oblong'dan da base'e (Shape'e) gidiyor.

            Console.ReadLine();
        }

        private static void Polymorphism()
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
