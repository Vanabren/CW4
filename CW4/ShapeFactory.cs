using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW4
{
    internal class ShapeFactory
    {
        // pass in type from main using enum 
        // return shape if exists
        // return null if it doesn't
        public IGeometricShape getShape(ShapeType type) 
        {

            switch (type)
            {
                case (ShapeType.Line):
                    return new Line();

                case (ShapeType.Circle):
                    return new Circle();

                case (ShapeType.Rectangle):
                    return new Rectangle();

                default:
                    return null;
            }
        }
    }
}
