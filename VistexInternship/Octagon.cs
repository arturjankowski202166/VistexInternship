using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    class Octagon : IShape
    {

        public Point[] CalculateCorners()
        {
            return ShapeCalculator.CalculateCorners(numberOfCorners, lenghtOfSide);
        }

        public double CalculateField()
        {
            return (lenghtOfSide * lenghtOfSide * Math.Sqrt(3)) / 2;
        }
        private double lenghtOfSide;
        private int numberOfCorners = 8;

        public Octagon(double lenghtOfSide)
        {
            if (lenghtOfSide > 0)
                this.lenghtOfSide = lenghtOfSide;
            else throw new ArgumentException();
        }
    }
}
