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
                x = r + r * Math.Cos((Math.PI / numberOfCorners) * (1 + 2 * i));
                y = r * Math.Sin((Math.PI / numberOfCorners) * (1 + 2 * i));
                cornerCoordinates[i] = new Point(x, y);
            }
            return cornerCoordinates;
        }
        public static double CalculateField(int numberOfCorners, double lenghtOfSide)
        {
            double R = lenghtOfSide / (2 * Math.Tan(Math.PI / numberOfCorners));
            double field = numberOfCorners * R * R * Math.Sin((2 * Math.PI) / numberOfCorners) * 0.5;
            return field;
        }
    }
}