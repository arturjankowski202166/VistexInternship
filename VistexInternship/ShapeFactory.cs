using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    public class ShapeFactory
    {
        public IShape CreateShape(double lenghtOfSide, int numberOfCorners)
        {
            switch(numberOfCorners)
            {
                case 3:
                    {
                        return new Triangle(lenghtOfSide);
                    }
                case 4:
                    {
                        return new Square(lenghtOfSide);
                    }
                case 5:
                    {
                        return new Pentagon(lenghtOfSide);
                    }
                case 6:
                    {
                        return new Hexagon(lenghtOfSide);
                    }
                case 7:
                    {
                        return new Heptagon(lenghtOfSide);
                    }
                case 8:
                    {
                        return new Octagon(lenghtOfSide);
                    }
                default:
                    { 
                            return new OtherShape(lenghtOfSide, numberOfCorners);
                    }
            }
        }
    }
}
