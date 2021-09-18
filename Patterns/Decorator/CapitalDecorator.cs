using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class CapitalDecorator : PrinterDecoratorBase
    {
        public CapitalDecorator(PrinterBase entity) : base(entity)
        {
        }

        public override void Print(string msg)
        {
            base.Print(msg.ToUpper());
        }
    }
}
