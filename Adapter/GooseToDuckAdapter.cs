namespace Adapter
{
    public class GooseToDuckAdapter : Duck
    {
        private readonly Goose _goose;

        public GooseToDuckAdapter(Goose goose)
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