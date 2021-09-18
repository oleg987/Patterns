using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    abstract class PrinterDecoratorBase : PrinterBase
    {
        protected PrinterBase _entity;

        protected PrinterDecoratorBase(PrinterBase entity)
        {
            _entity = entity;
        }

        public override void Print(string msg)
        {
            _entity.Print(msg);
        }
    }
}
