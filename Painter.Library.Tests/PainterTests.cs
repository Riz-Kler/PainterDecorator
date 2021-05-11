using NUnit.Framework;
using System;

namespace Painter.Library.Tests
{
    [TestFixture]
    public class PainterTests
    {
        [Test]
        public void Floor_Area__When11_Returns1()
        {
            //Arrange

            double length = 1;
            double width = 1;

            //Act
            double floorArea = PaintRoom.FloorArea(length, width);

            //Asserts
            Assert.AreEqual("1", floorArea);
        }
        [Test]
        public void Floor_Area__When22_Returns4()
        {
            //Arrange

            double length = 2;
            double width = 2;

            //Act
            double floorArea = PaintRoom.FloorArea(length, width);

            //Asserts
            Assert.AreEqual("4", floorArea);
        }

        [Test]
        public void Floor_Area__When00_Returns0()
        {
            //Arrange

            double length = 0;
            double width = 0;

            //Act
            double floorArea = PaintRoom.FloorArea(length, width);

            //Asserts
            Assert.AreEqual("0", floorArea);
        }
        [Test]
        public void Floor_Area__WhenMinus15_Returns0()
        {
            //Arrange

            double length = -1;
            double width = 5;

            //Act
            double floorArea = PaintRoom.FloorArea(length, width);

            //Asserts
            Assert.AreEqual("-5", floorArea);
        }

        [Test]
        public void Floor_Area__When5Minus1_Returns0()
        {
            //Arrange

            double length = 5;
            double width =-1;

            //Act
            double floorArea = PaintRoom.FloorArea(length, width);

            //Asserts
            Assert.AreEqual("-5", floorArea);
        }

        [Test]
        public void Painted_Area_When000_Returns0()
        {
            //Arrange

            double length = 0;
            double width = 0;
            double height = 0;

            //Act
            double paintedArea = PaintRoom.PaintedArea(length, width, height);

            //Asserts
            Assert.AreEqual("0", paintedArea);

        }

        public void Painted_Area_When111_Returns1()
        {
            //Arrange

            double length = 1;
            double width = 1;
            double height = 1;

            //Act
            double paintedArea = PaintRoom.PaintedArea(length, width, height);

            //Asserts
            Assert.AreEqual("1", paintedArea);
         }
    }
}
