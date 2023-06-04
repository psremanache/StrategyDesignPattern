using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class NormalRide:IRideStategy
    {
        public void Ride()
        {
            Console.WriteLine("This has Normal Ride");
        }
    }
}
