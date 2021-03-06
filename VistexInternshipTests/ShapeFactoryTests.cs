﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using VistexInternship;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VistexInternship.Tests
{
    [TestClass()]
    public class ShapeFactoryTests
    {
        ShapeFactory sf;
        [TestInitialize()]
        public void initTest()
        {
            sf = new ShapeFactory();
        }

        [TestMethod()]
        public void CreatingShapeShouldReturnShapeForEveryValidNumberOfCorners()
        {
            IShape shape = null;
            for (int i = 3; i < 30; i++)
            {
                shape = sf.CreateShape(4, i);
                Assert.IsNotNull(shape);
                shape = null;
            }
        }

            [TestMethod()]
        public void CreatingShapeShouldThrowExceptionForEveryInvalidNumberOfCorners()
        {
            IShape shape = null;
            ArgumentException expectedException = null;
            for (int i = 2; i > -10; i--)
            {
                expectedException = null;
                try
                {
                    shape = sf.CreateShape(5, i);
                }
                catch (ArgumentException ex)
                {

                    expectedException = ex;
                }
                Assert.IsNotNull(expectedException);
            }

        }

        [TestMethod()]
        public void CreatingShapeShouldThrowExceptionForEveryInvalidLenghtOfSide()
        {
            IShape shape = null;

            for (int i = 3; i < 10; i++)
            {
                ArgumentException expectedException = null;
                try
                {
                    shape = sf.CreateShape(0, i);
                }
                catch (ArgumentException ex)
                {

                    expectedException = ex;
                }
                Assert.IsNotNull(expectedException);
            }
        }
                
            [TestMethod()]
        public void CreatingShapeShouldReturnShapeForEveryValidLenghtOfSide()
        {
            IShape shape = null;

            for (int i = 3; i < 10; i++)
            {
                ArgumentException expectedException = null;
                shape = null;
                try
                {
                    shape = sf.CreateShape(2, i);
                }
                catch (ArgumentException ex)
                {

                    expectedException = ex;
                }
                Assert.IsNull(expectedException);
                Assert.IsNotNull(shape);
            }
        }
        [TestMethod()]
        public void ShapeShouldHaveEqualSides()
        {
            IShape shape = null;

            for (int i = 3; i < 10; i++)
            {
                shape = sf.CreateShape(5, i);
                Point[] array = shape.CalculateCorners();
                for (int j = 1; j < array.Length; j++)
                {
                    double calculatedLenght = Math.Sqrt(Math.Pow(array[j].x - array[j - 1].x, 2) + Math.Pow(array[j].y - array[j - 1].y, 2));
                    Assert.AreEqual(5, Math.Round(calculatedLenght));
                }

            }
        }
    }
}