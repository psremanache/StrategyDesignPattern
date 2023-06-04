using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Bike
    {
        IRideStategy obj;
        public Bike(IRideStategy obj)
        {
            this.obj = obj;
        }

        public void Ride()
        {
            obj.Ride();
        }
    }
}
