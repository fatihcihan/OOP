using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Inheritance
{
    public class Shape
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        public virtual void Draw()      // virtual -> temel class'tan uretilen classlarda override edilebilir, yani gecersiz kilip ezebiliriz. Propertyler icin de kullanilir.
        {
            Console.WriteLine("Base class drawing task.");
        }
    }
}
