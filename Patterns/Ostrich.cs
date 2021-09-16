using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Ostrich : Bird
    {
        public override void Move()
        {
            Console.WriteLine("Run");
        }
    }
}
