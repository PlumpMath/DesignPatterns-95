using Strategy.Fly;
using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            this.quackable = new NoQuack();
            this.flyable = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("I'm wooden duck!");
        }
    }
}
