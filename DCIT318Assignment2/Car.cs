using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCIT318Assignment2
{
    internal class Car : IMovable
    {
        public void Move()
        { 
        Console.WriteLine("Car is moving");
        }
    }
}
