using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.State
{
    public enum States
    {
        Forward,
        Nitro,
        Break
    }

    class InputSystem
    {
        private MovingState _state;
        public States Input { get; set; }
        // Some props

        public void LifeCicle()
        {
            switch (Input)
            {
                case States.Forward:
                    var state = new ForwardState(this);
                    state.Execute();
                    break;
            }
        }
    }
}
