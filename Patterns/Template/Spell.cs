using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Template
{
    abstract class Spell
    {
        public virtual void Attack()
        {
            // Preconditions
            Preconditions();
            // Check Resource

            // Minus resouse

            // Delay
            Delay();
            // Make Damage
        }

        protected virtual void Preconditions() { }
        protected virtual void Delay() { }
    }
}
