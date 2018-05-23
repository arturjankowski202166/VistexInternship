using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    class Hexagon : IShape
    {
        public Point[] CalculateCorners()
        {
            return ShapeCalculator.CalculateCorners(numberOfCorners, lenghtOfSide);
        }

        public double CalculateField()
        {
            return 6 * (lenghtOfSide * lenghtOfSide * Math.Sqrt(3)) / 2;
        }
        private double lenghtOfSide;
        private int numberOfCorners = 6;

        public Hexagon(double lenghtOfSide)
        {
            if (lenghtOfSide > 0)
                this.lenghtOfSide = lenghtOfSide;
            else throw new ArgumentException();
        }
    }
}
