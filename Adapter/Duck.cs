using System;

namespace Adapter
{
    public abstract class Duck
    {
        public virtual void Fly()
        {
            Console.WriteLine("Утка летит");
        }
        public virtual void Quack()
        {
            Console.WriteLine("Утка крякает");
        }
    }
}