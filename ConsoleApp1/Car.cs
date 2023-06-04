using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Car
    {
        public virtual void Drive()
        {
            Console.WriteLine("Normal Drive method");
        }
    }
}
