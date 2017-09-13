using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    // Implements the Pizza interface with only the required
    // methods from the interface

    // Every Pizza made will start as a PlainPizza
    class PlainPizza : IPizza
    {
        public virtual double getCost()
        {
            Console.WriteLine("Cost of Dough: " + 4.00);
            return 4.00;
        }

        public virtual string getDescription()
        {
            return "Thin dough";
        }
    }
}
