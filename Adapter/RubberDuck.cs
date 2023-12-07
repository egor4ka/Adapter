using System;

namespace Adapter
{
    public class RubberDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Резиновая утка не летает");
        }
        public override void Quack()
        {
            Console.WriteLine("Резиновая утка крякает");
        }
    }
}