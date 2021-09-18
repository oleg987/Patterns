using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Decorator
{
    class AlarmDecorator : PrinterDecoratorBase
    {
        public AlarmDecorator(PrinterBase entity) : base(entity)
        {
        }

        public override void Print(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            base.Print(msg);            
        }
    }
}
