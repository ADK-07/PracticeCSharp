using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Car
    {
        public string brand;
        public string color;
        public string spped;

        public void Speed()
        {
            if ( brand != null)
            {
                Console.WriteLine("Max speed of car is 300km/hr");
            }
        }
    }
    
}
