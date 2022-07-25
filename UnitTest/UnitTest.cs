using Microsoft.VisualStudio.TestTools.UnitTesting;
using MindBox;
using System;

namespace UnitTest
{
    [TestClass]
    public class UnitTest
    {
        [TestClass]
        public class CircleTest
        {
            [TestMethod]
            public void Square_4_Return_50_27()
            {
                //arrange
                Circle circle = new Circle("Circle", 4);
                double expected = 50.27;

                //act
                double result = circle.CSquare();

                //assert
                Assert.AreEqual(expected, result);
            }
        }

        [TestClass]
        public class TriangleTest
        {
            [TestMethod]
            public void Square_4_2_3_Return_2_9()
            {
                //arrange
                Triangle triangle = new Triangle("Triangle", 4, 2, 3);
                double expected = 2.9;

                //act
                double result = triangle.CSquare();

                //assert
                Assert.AreEqual(expected, result);
            }

            [TestMethod]
            public void isRectangle_Rectangle_ReturnTrue()
            {
                //Arrange
                var triangle = new Triangle("Triangle", 10, 8, 6);

                //Act
                var result = triangle.IsRectangular();

                //Assert
                Assert.IsTrue(result);
            }
        }
    }
}
