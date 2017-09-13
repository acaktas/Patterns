using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            // The PlainPizza object is sent to the Mozzarella constructor
            // and then to the TomatoSauce constructor

            TomatoSauce basicPizza = new TomatoSauce(new Mozzarella(new PlainPizza()));

            Console.WriteLine("Ingredients: " + basicPizza.getDescription());
            Console.WriteLine("Price: " + basicPizza.getCost());
 
            Console.ReadLine();
        }
    }
}
