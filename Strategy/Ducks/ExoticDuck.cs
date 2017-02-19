using Strategy.Fly;
using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public class ExoticDuck : Duck
    {
        public ExoticDuck()
        {
            this.quackable = new SimpleQuack();
            this.flyable = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm exotic duck!");
        }
    }
}
