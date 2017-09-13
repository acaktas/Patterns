using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    public class Bird : Animal
    {
        public Bird()
        {
            // We set the Flys interface polymorphically
            // This sets the behavior as a flying Animal

            this.flyingType = new ItFlys();
        }
    }
}
