using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    class Car
    {
        public Engine Engine { get; set; }
        public int Price { get; set; }
        public int WheelCount { get; set; }
    }
}
