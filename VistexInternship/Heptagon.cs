using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    class Heptagon : IShape
    {

        public double CalculateField()
        {
            return ShapeCalculator.CalculateField(numberOfCorners, lenghtOfSide);
        }

        public Point[] CalculateCorners()
        {
            return ShapeCalculator.CalculateCorners(numberOfCorners, lenghtOfSide);
        }

        private double lenghtOfSide;
        private int numberOfCorners = 7;

        public Heptagon(double lenghtOfSide)
        {
            if (lenghtOfSide > 0)
                this.lenghtOfSide = lenghtOfSide;
            else throw new ArgumentException();
        }
    }
}
