using System;
using System.Collections.Generic;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Penguin();
            var e = new Eagle();
            var o = new Ostrich();

            p.Move();
            e.Move();
            o.Move();

            List<Bird> birds = new List<Bird> { p, e, o };

            foreach (var item in birds)
            {
                item.Move();
            }

            Console.WriteLine(p);
        }
    }
}
