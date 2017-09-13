using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Strategy
{
    // The interface is implemented by many other    
    // subclasses that allow for many types of flying    
    // without effecting Animal, or Flys.
    
    // Classes that implement new Flys interface    
    // subclasses can allow other classes to use    
    // that code eliminating code duplication
    
    // I'm decoupling : encapsulating the concept that varies

    public interface IFlys
    {
        string fly();
    }

    // Class used if the Animal can fly
    class ItFlys : IFlys
    {
        public string fly()
        {
            return "Flying High";
        }
    }

    // Class used if the Animal can't fly
    class CantFly : IFlys
    {
        public string fly()
        {
            return "I can't fly";
        }
    }
}
