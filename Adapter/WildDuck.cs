using System;

namespace Adapter
{
    public class WildDuck : Duck
    {
        public override void Quack()
        {
            Console.WriteLine("Утка крячет");
        }

        public override void Fly()
        {
            Console.WriteLine("Утка летает");
        }
    }
}