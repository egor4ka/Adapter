﻿using System;
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

            foreach (var duck in ducks)
            {
                if (duck is Turkey)
                {
                    Duck Adapter = new Adapter(turkey);
                    Adapter.Quack();
                    Adapter.Fly();
                }
                else
                {
                    duck.Quack();
                    duck.Fly();
                }
                Console.WriteLine();
            }
        }
    }
}
