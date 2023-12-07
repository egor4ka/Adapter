using System;

namespace Adapter
{
    public class RubberDuck : Duck
    {
        public override void Fly()
        {
            Console.WriteLine("Уточка летает");
        }
        public override void Quack()
        {
            Console.WriteLine("Резиновая утка крякает");
        }
    }
}