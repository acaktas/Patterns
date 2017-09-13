using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class MonitorDisplay : IObserver
    {
        WetherStation _station;
        public MonitorDisplay(WetherStation station)
        {
            _station = station;
        }

        public void Update()
        {
            Console.WriteLine("Temperature for monitor display is: " + _station.GetTemperature());
        }
    }
}
