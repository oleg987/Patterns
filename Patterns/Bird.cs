using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    abstract class Bird
    {
        public virtual void Move()
        {
            Console.WriteLine("Fly");
        }
    }
}
