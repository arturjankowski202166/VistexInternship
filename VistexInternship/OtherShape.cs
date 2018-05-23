using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    class OtherShape : IShape
    {
        public Point[] CalculateCorners()
        {
            return ShapeCalculator.CalculateCorners(numberOfCorners, lenghtOfSide);
        }

        public double CalculateField()
        {
            double r;
            r = lenghtOfSide / (2 * Math.Tan(Math.PI / numberOfCorners));
            return (numberOfCorners*lenghtOfSide*r);
        }

        private double lenghtOfSide;
        private int numberOfCorners;

        public OtherShape(double lenghtOfSide, int numberOfCorners)
        {
            if (lenghtOfSide > 0)
                this.lenghtOfSide = lenghtOfSide;
            else throw new ArgumentException();
            if (numberOfCorners > 3)
                this.numberOfCorners = numberOfCorners;
            else throw new ArgumentException();
        }
    }
}
