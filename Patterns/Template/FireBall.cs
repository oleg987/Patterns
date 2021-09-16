using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template
{
    class FireBall : Spell
    {
        protected override void Delay()
        {
            // custom delay
        }
    }
}
