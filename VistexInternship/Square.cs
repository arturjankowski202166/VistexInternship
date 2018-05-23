using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    class Square : IShape
    {
        public Point[] CalculateCorners()
        {
            return ShapeCalculator.CalculateCorners(numberOfCorners, lenghtOfSide);
        }

        public double CalculateField()
        {
            return lenghtOfSide * lenghtOfSide;
        }
        private double lenghtOfSide;
        private int numberOfCorners = 4;
        public Square(double lenghtOfSide)
        {
            if (lenghtOfSide > 0)
                this.lenghtOfSide = lenghtOfSide;
            else throw new ArgumentException();
        }
    }
}
