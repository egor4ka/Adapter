using System;

namespace Adapter
{
    public class Goose
    {
        public void Cackling()
        {
            Console.WriteLine("Гусь гогочет");
        }
        public void Fly()
        {
            Console.WriteLine("Гусь летает");
        }
    }
}