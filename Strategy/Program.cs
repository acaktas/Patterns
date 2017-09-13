using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal sparky = new Dog();
            Animal tweety = new Bird();

            // This allows dynamic changes for flyingType
            sparky.setFlyAbility(new CantFly());
            tweety.setFlyAbility(new ItFlys());

            Console.WriteLine(sparky.tryToFly());
            Console.WriteLine(tweety.tryToFly());
            Console.ReadLine();
        }
    }
}
