using System;

namespace VistexInternship
{
    public static class ShapeCalculator
    {
        public static Point[] CalculateCorners(int numberOfCorners, double lenghtOfSide)
        {
            Point[] cornerCoordinates = new Point[numberOfCorners];
            double r = lenghtOfSide / (2 * Math.Sin(Math.PI / numberOfCorners));
            for (int i = 0; i < numberOfCorners; i++)
            {
                double x, y;
                x = r * Math.Cos((Math.PI / numberOfCorners) * (1 + 2 * (i + 86 * Math.PI / 180)));
                y = r * Math.Sin((Math.PI / numberOfCorners) * (1 + 2 * (i - Math.PI / 6)));
                cornerCoordinates[i] = new Point(x, y);
            }
            return cornerCoordinates;
        }
    }
}