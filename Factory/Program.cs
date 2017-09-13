using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFactory pizzaFactory = new PizzaFactory();
            Pizza nyPizza = pizzaFactory.OrderPizza("N");
            Pizza chicagoPizza = pizzaFactory.OrderPizza("C");

            Console.WriteLine();
            Console.WriteLine("Ethan ordered a " + nyPizza.Name + "\n");

            Console.WriteLine("Joel ordered a " + chicagoPizza.Name + "\n");

            Console.ReadLine();
        }
    }
}
