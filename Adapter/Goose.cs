using System;

namespace Adapter
{
    public class Turkey : Duck
    {
        public void Fly()
        {
            Console.WriteLine("Индюк летит");
        }
        public void Gobble()
        {
            Console.WriteLine("Индюк гогочет");
        }
    }
}