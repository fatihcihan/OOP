using System;

namespace OOP.Inheritance
{
    public class Square : Oblong        // Multi-level inheritance. Base class'takileri de miras olarak aldi. Cok abartmamak lazim.
    {
        public void Calculate()
        {
            Console.WriteLine("Calculated by Square.");
        }
    }
}
