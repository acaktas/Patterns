using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PizzaFactory
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }
        private Pizza CreatePizza(string type)
        {
            if (type.Equals("N"))
            {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("C"))
            {
                return new ChicagoStyleCheesePizza();
            }
            else
            {
                return null;
            }
        }        
    }
}
