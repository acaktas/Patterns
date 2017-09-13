using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Dog : Animal
    {
        public Dog()
        {
            // We set the Flys interface polymorphically
            // This sets the behavior as a non-flying Animal

            this.flyingType = new CantFly();
        }
    }
}
