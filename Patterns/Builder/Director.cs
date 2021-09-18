using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Builder
{
    class Director
    {
        private CarBuilder _carBuilder;
        private ManualBuilder _manualBuilder;

        public Director()
        {
            _carBuilder = new CarBuilder();
            _manualBuilder = new ManualBuilder();
        }

        public Director SetEngine(Engine eng)
        {
            _carBuilder.SetEngine(eng);
            _manualBuilder.SetEngine(eng);
            return this;
        }

        public Director SetPrice(int price)
        {
            return this;
        }

        public (Car, Manual) Build()
        {
            return (_carBuilder.Build(),_manualBuilder.Build()); // Именованый кортеж.
        }
    }
}
