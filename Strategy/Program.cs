using Strategy.Ducks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>();
            ducks.Add(new SimpleDuck());
            ducks.Add(new ExoticDuck());
            ducks.Add(new WoodenDuck());
            ducks.Add(new RubbleDuck());

            foreach (Duck duck in ducks)
            {
                duck.Display();
                duck.Sweem();
                duck.Quack();
                duck.Fly();

                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
