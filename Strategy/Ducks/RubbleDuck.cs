using Strategy.Fly;
using Strategy.Quack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    class RubbleDuck : Duck
    {
        public RubbleDuck()
        {
            this.quackable = new SimpleQuack();
            this.flyable = new NoFly();
        }

        public override void Display()
        {
            Console.WriteLine("I'm rubble duck");
        }
    }
}
