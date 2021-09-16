using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Penguin : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Swim");
        }
    }
}
