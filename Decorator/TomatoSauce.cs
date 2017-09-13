using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class TomatoSauce : ToppingDecorator
    {
        public TomatoSauce(IPizza pizza) : base(pizza)
        {
            Console.WriteLine("Adding Sauce");
        }

        // Returns the result of calling getDescription() for
        // PlainPizza, Mozzarella and then TomatoSauce

        public override string getDescription()
        {
            return base._pizza.getDescription() + ", tomato sauce";
        }

        public override double getCost()
        {
            Console.WriteLine("Cost of Sauce: " + .35);
            return base._pizza.getCost() + .35;
        }
    }
}
