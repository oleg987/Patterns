using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    abstract class MovingState
    {
        protected InputSystem _input;

        protected MovingState(InputSystem input)
        {
            _input = input;
        }

        public abstract void Execute();
    }
}
