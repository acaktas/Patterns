using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Has a "Has a" relationship with Pizza. This is an
    // Aggregation Relationship
    public abstract class ToppingDecorator : IPizza
    {
        protected IPizza _pizza;

        // Assigns the type instance to this attribute
        // of a Pizza

        // All decorators can dynamically customize the Pizza
        // instance PlainPizza because of this
        public ToppingDecorator(IPizza pizza)
        {
            _pizza = pizza;
        }
        public virtual double getCost()
        {
            return  _pizza.getCost();
        }

        public virtual string getDescription()
        {
            return _pizza.getDescription();
        }
    }
}
