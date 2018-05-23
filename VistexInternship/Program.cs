using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship
{
    public class Program
    {
        static int Main(string[] args)
        {
            Console.WriteLine(args[0] + " " + args[1]);
            int numberOfCorners = 0;
            double lenghtOfSide;
            try
            {
                numberOfCorners = int.Parse(args[1]);
                if (numberOfCorners <= 2)
                    throw new FormatException();
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid parameter [1], please provide Integer value bigger than 2 - program will exit");
                Console.ReadKey();
                return -1;
            }
            try
            {
                lenghtOfSide = double.Parse(args[0]);
                if (lenghtOfSide <= 0)
                    throw new FormatException();
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid parameter [0], please provide Double positive value - program will exit");
                Console.ReadKey();
                return -2;
            }
            ShapeFactory factory = new ShapeFactory();
            IShape shape = factory.CreateShape(lenghtOfSide, numberOfCorners);
            
            //TODO save to file or print on console
            switch(args[2])
                {
                case "f":
                    {
                        Console.WriteLine("Chosen print to file");
                        break;
                    }
                case "c":
                    {
                        Console.WriteLine("Field of shape: {0}", shape.CalculateField());
                        Console.WriteLine("List of corners of this shape:");
                        Point[] list = shape.CalculateCorners();
                        for (int i = 0; i < numberOfCorners; i++)
                        {
                            Console.WriteLine("X = {0}; Y = {1}", Math.Round(list[i].x,4), Math.Round(list[i].y));
                        }
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Invalid 3rd argument provided");
                        Console.WriteLine("Please provide \"c\" for console print and \"f\" for file save");
                        break;
                    }
                }
            Console.ReadKey();
            return 0;
        }
    }
}
