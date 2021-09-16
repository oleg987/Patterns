using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    class NitroState : MovingState
    {
        public NitroState(InputSystem input) : base(input)
        {
        }

        public override void Execute()
        {
            throw new NotImplementedException();
        }
    }
}
