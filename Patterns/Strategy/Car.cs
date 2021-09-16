using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class Car
    {
        public IMovebale MoveStrategy { get; set; }

        public Car()
        {
            MoveStrategy = new SlowMove();
        }

        public void ChangeStrategy(IMovebale s)
        {
            MoveStrategy = s;
        }

        public virtual void Move()
        {
            MoveStrategy.Move();
        }
    }
}
