namespace Adapter
{
    public class DuckToTurkeyAdapter : Duck
    {
        private Turkey _turkey;

        public DuckToTurkeyAdapter(Turkey turkey)
        {
            if (turkey!=null) this._turkey = turkey;
        }

        public override void Quack()
        {
            _turkey.Gobble();
        }

        public override void Fly()
        {
            _turkey.Fly();
        }
    }
}