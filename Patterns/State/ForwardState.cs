using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    class ForwardState : MovingState
    {
        public ForwardState(InputSystem input) : base(input)
        {
        }

        public override void Execute()
        {
            // hard logic.

            // loop
            switch (_input.Input)
            {
                case States.Nitro:
                    var state = new NitroState(_input);
                    state.Execute();
                    break;
                case States.Break:
                    var breack = new BreackingState(_input);
                    breack.Execute();
                    break;
            }
        }
    }
}
