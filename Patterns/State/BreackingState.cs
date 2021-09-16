using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    class BreackingState : MovingState
    {
        public BreackingState(InputSystem input) : base(input)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
