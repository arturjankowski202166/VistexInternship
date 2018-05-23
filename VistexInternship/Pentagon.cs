using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    class Pentagon : IShape
    {
        public Point[] CalculateCorners()
        {
            return ShapeCalculator.CalculateCorners(numberOfCorners,lenghtOfSide);
        }

        public double CalculateField()
        {
            return 5 * lenghtOfSide * lenghtOfSide * Math.Cos(0.628318531);
        }
        private double lenghtOfSide;
        private int numberOfCorners = 5;

        public Pentagon(double lenghtOfSide)
        {
            if (lenghtOfSide > 0)
                this.lenghtOfSide = lenghtOfSide;
            else throw new ArgumentException();
        }
    }
}
