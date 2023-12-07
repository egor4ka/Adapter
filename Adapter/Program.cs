using System;
using System.Collections.Generic;

namespace Adapter
{
    class Program
    {
        static void Main(string[] argz)
        {
            List<Duck> ducks = new List<Duck>();
            ducks.Add(new RubberDuck());
            ducks.Add(new WildDuck());
            Turkey turkey = new Turkey();
            ducks.Add(turkey);

            Duck wildDuck = new WildDuck();

            Goose goose = new Goose();
            Duck gooseAdapter = new DuckToGooseAdapter(goose);

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
