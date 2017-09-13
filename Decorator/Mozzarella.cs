using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Mozzarella : ToppingDecorator
    {
        public Mozzarella(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding Dough");
            Console.WriteLine("Adding Moz");
        }

        // Returns the result of calling getDescription() for
        // PlainPizza and adds " mozzarella" to it

        public override string getDescription()
        {
            return base._pizza.getDescription() + ", mozzarella";
        }

        public override double getCost()
        {
            Console.WriteLine("Cost of Moz: " + .50);
            return base._pizza.getCost() + .50;
        }
    }
}
