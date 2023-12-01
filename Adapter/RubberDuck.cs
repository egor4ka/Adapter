using System;

namespace Adapter
{
    public class RubberDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Уточка не летает");
        }
        public override void Quack()
        {
            Console.WriteLine("Уточка крякает");
        }
    }
}