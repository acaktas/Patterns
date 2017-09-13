using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // By going this route I'll have to create a new subclass
    // for an infinite number of pizza.
    // I'd also have to change prices in many classes 
    // when just 1 Pizza topping cost changes

    // Inheritance is static while composition is dynamic
    // Through composition I'll be able to add new functionality
    // by writing new code rather than by changing current code
    class ThreeCheesePizza : IPizza
    {
        public string _description { private get; set; }
        public double _cost { private get; set; }

        public ThreeCheesePizza()
        {
            _description = "Mozzarella, Fontina, Parmesan Cheese Pizza";
            _cost = 10.50;
        }
        public virtual double getCost()
        {
            return _cost;
        }

        public virtual string getDescription()
        {
            return _description;
        }
    }
}
