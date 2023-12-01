using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] argz)
        {
            Duck rubberDuck = new RubberDuck();

            Duck wildDuck = new WildDuck();

            Goose goose = new Goose();
            Duck gooseAdapter = new GooseToDuckAdapter(goose);

            Console.WriteLine("Резиновая уточка:");
            rubberDuck.Quack();
            rubberDuck.Fly();

            Console.WriteLine("\nГусь-адапетр:");
            gooseAdapter.Quack();
            gooseAdapter.Fly();

            Console.WriteLine("\nДикая утка:");
            wildDuck.Quack();
            wildDuck.Fly();

            Console.ReadLine();
        }
    }
}
