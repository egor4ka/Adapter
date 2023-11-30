namespace Adapter
{
    public class DuckToGooseAdapter : Duck
    {
        private readonly Goose _goose;

        public DuckToGooseAdapter(Goose goose)
        {
            _goose = goose;
        }

        public override void Quack()
        {
            _goose.Cackling();
        }

        public override void Fly()
        {
            _goose.Fly();
        }
    }
}