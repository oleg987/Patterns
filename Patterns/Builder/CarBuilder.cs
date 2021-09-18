using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    class CarBuilder
    {
        private Car _car;

        public CarBuilder()
        {
            _car = new Car();
        }

        public CarBuilder SetEngine(Engine eng)
        {
            _car.Engine = eng;
            return this;
        }

        public CarBuilder SetPrice(int price)
        {
            _car.Price = price;
            return this;
        }

        public Car Build()
        {
            return _car;
        }
    }
}
