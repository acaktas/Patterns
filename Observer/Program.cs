using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WetherStation station = new WetherStation();
            PhoneDisplay phoneDisplay = new PhoneDisplay(station);
            MonitorDisplay monitorDisplay = new MonitorDisplay(station);

            station.Register(phoneDisplay);
            station.Register(monitorDisplay);

            for (int i = 1; i <= 10; i++)
            {
                Thread.Sleep(2000);
                station.Notify();
            }

            Console.ReadLine();
        }
    }
}
