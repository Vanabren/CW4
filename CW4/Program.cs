using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShapeFactory factory = new ShapeFactory();

            foreach (ShapeType t in Enum.GetValues(typeof(ShapeType)))
            {
                IGeometricShape x = factory.getShape(t);
                if (x != null)
                {
                    x.draw();
                }
                else
                {
                    Console.WriteLine(t + " does not exist.");
                }
                
            }
        }
    }
}
