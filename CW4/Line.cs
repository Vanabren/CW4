using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4
{
    internal class Line : IGeometricShape
    {
        public void draw()
        {
            Console.WriteLine("Line is drawn.");
        }
    }
}
