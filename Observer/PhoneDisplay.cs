using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class PhoneDisplay : IObserver
    {
        WetherStation _station;
        public PhoneDisplay(WetherStation station)
        {
            _station = station;
        }

        public void Update()
        {
            Console.WriteLine("Temperature for phone display is: " + _station.GetTemperature());
        }
    }
}
