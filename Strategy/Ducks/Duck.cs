using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Ducks
{
    public abstract class Duck
    {
        protected IQuackable quackable;
        protected IFlyable flyable;

        public abstract void Display();

        public void Sweem() {
            Console.WriteLine("Swiming!");
        }

        public void Quack() {
            quackable.Quack();
        }

        public void Fly() {
            flyable.Fly();
        }
    }
}
