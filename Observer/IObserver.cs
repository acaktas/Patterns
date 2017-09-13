using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    // The Observers update method is called when the Observable changes

    public interface IObserver
    {
        void Update();
    }
}
