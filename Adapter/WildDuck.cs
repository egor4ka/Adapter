using System;

namespace Adapter
{
    public class WildDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Дикая утка летает");
        }
        public override void Quack()
        {
            Console.WriteLine("Дикая утка крякает");
        }
    }
}