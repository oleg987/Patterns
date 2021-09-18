namespace Patterns.Builder
{
    internal class ManualBuilder
    {
        private Manual _manual;

        public ManualBuilder()
        {
            _manual = new Manual();
        }

        public ManualBuilder SetEngine(Engine eng)
        {
            _manual.Engine = eng;
            return this;
        }

        public ManualBuilder SetPrice(int price)
        {
            _manual.Price = price;
            return this;
        }

        public Manual Build()
        {
            return _manual;
        }
    }
}