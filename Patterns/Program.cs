using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            Builder.CarBuilder builder = new Builder.CarBuilder();

            Builder.Car car = builder
                .SetEngine(new Builder.Engine())
                .SetPrice(15000)
                .Build();

            Builder.Director dir = new Builder.Director();

            var tuple = dir.SetEngine(new Builder.Engine()).Build();

            Console.WriteLine(tuple.Item1);
            Console.WriteLine(tuple.Item2);

            var decorator = new Decorator.CapitalDecorator(new Decorator.AlarmDecorator(new Decorator.ConsolePrinter()));

            decorator.Print("Hello");
        }
    }
}
